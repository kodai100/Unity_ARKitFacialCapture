using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

using UniRx;

using Debug = UnityEngine.Debug;


namespace ProjectBlue.NetworkCommunication
{
    public sealed class UdpServerProxy<T> : IDisposable
    {
        volatile bool loopFlg = true;
        IObservable<T> subject = default;
        UdpClient udpClient = default;

        public UdpServerProxy(int port, Func<byte[], IPEndPoint, T> proccess)
        {
            var queue = new ConcurrentQueue<(byte[] buffer, IPEndPoint endPoint)>();
            var ip = new IPEndPoint(IPAddress.Any, port);
            udpClient = new UdpClient(ip);

            Task.Run(() =>
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
                }
               
            });

            subject = Observable
               .Create<T>(observable =>
                {
                    while (loopFlg)
                    {
                        while (queue.TryDequeue(out var result))
                        {
                            var value = proccess(result.buffer, result.endPoint);
                            observable.OnNext(value);
                        }
                    }
                    observable.OnCompleted();
                    return Disposable.Empty;
                })
                .SubscribeOn(Scheduler.ThreadPool)
                .ObserveOnMainThread()
                .Share();

            Observable
                .OnceApplicationQuit()
                .Subscribe(_ => Dispose());
        }

        public IObservable<T> OnValueChanged()
        {
            return subject;
        }

        public void Dispose()
        {
            if (loopFlg)
            {
                loopFlg = false;
            }
        }
    }
}