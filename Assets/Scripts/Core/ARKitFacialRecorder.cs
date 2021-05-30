using System;
using System.Diagnostics;
using System.IO;
using UniRx;
using ZeroFormatter;

using Debug = UnityEngine.Debug;

namespace ProjectBlue.FacialCapture.Core
{

    public class ARKitFacialRecorder : IDisposable
    {


        bool record = false;

        Stopwatch stopwatch;

        SingleAssignmentDisposable disposable = new SingleAssignmentDisposable();

        public ARKitFacialRecorder()
        {

            stopwatch = new Stopwatch();

            // disposable.Disposable = Observable.EveryUpdate().Subscribe(_ => RecordUpdate());

            Observable
                    .OnceApplicationQuit()
                    .Subscribe(_ => Dispose());
        }

        MemoryStream memoryStream;

        public void RecordUpdate(ARKitFacialValues arkitFacialValues)
        {

            if (!record) return;

            var elapsedTicks = stopwatch.ElapsedTicks;

            arkitFacialValues.elapsedTicks = elapsedTicks;

            var bytes = ZeroFormatterSerializer.Serialize(arkitFacialValues);

            memoryStream.Write(bytes, 0, bytes.Length);
        }

        public void StartRecording()
        {

            Debug.Log("Record started.");

            if (!record)
            {

                record = true;

                memoryStream = new MemoryStream();

                stopwatch.Reset();
                stopwatch.Start();
            }

        }

        public void StopRecording()
        {
            if (!record) return;

            record = false;

            string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"FaceCapture_{DateTime.Now.ToString("yyyy-dd-M-HH-mm-ss")}.bytes");

            using (var fileStream = new FileStream(savePath, FileMode.CreateNew, FileAccess.ReadWrite))
            {

                if (memoryStream != null)
                {

                    memoryStream.Position = 0;
                    memoryStream.CopyTo(fileStream);

                    Debug.Log($"File saved as [{savePath}] : {fileStream.Length} bytes.");

                    memoryStream.Close();
                    memoryStream = null;
                }

            }

            stopwatch.Stop();

            Debug.Log("Record finished.");
        }

        public void Dispose()
        {
            StopRecording();
        }

    }

}