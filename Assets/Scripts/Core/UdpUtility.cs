using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UniRx;
using Debug = UnityEngine.Debug;


namespace ProjectBlue.NetworkCommunication
{
    public sealed class UdpServerProxy : IDisposable
    {
        volatile bool loopFlg = true;
        UdpClient udpClient = default;

        private Thread thread;

        private CompositeDisposable disposable = new CompositeDisposable();

        ConcurrentQueue<(byte[] buffer, IPEndPoint endPoint)> queue =
            new ConcurrentQueue<(byte[] buffer, IPEndPoint endPoint)>();

        public UdpServerProxy(int port, Action<byte[], IPEndPoint> proccess)
        {
            var ip = new IPEndPoint(IPAddress.Any, port);
            udpClient = new UdpClient(ip);

            thread = new Thread(Thread) {IsBackground = true};
            thread.Start();

            Observable.EveryUpdate().Subscribe(_ =>
            {
                while (queue.TryDequeue(out var result))
                {
                    proccess(result.buffer, result.endPoint);
                }
            }).AddTo(disposable);

            Observable.OnceApplicationQuit().Subscribe(_ => Dispose());
        }

        private void Thread()
        {
            using (udpClient)
            {
                while (loopFlg)
                {
                    try
                    {
                        var result = udpClient.ReceiveAsync();
                        if (result.Result.Buffer.Length > 0)
                        {
                            queue.Enqueue((result.Result.Buffer, result.Result.RemoteEndPoint));
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.LogException(e);
                    }
                }

                Debug.Log("Dispose");
            }
        }

        public void Dispose()
        {
            if (loopFlg)
            {
                loopFlg = false;
                disposable.Dispose();
            }

            if(thread != null)
            {
                thread.Abort();
                thread = null;
            }
        }
    }
}