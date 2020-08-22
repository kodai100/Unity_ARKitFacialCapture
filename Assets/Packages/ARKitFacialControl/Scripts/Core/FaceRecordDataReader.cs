using ProjectBlue.FacialCapture;
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Timeline;
using ZeroFormatter;

namespace ProjectBlue.FacialCapture.Core
{

    public class FaceRecordDataReader : MonoBehaviour, ITimeControl
    {

        static readonly int bufferLength = 436;

        [SerializeField]
        ARKitFacialControl facialControl;

        [SerializeField]
        TextAsset asset;

        public void OnControlTimeStart()
        {
            ZeroFormatterInitializer.Register();
        }

        public void OnControlTimeStop()
        {

        }

        public void SetTime(double time)
        {
            if (!asset) return;

            var bytes = asset.bytes;
            int totalFrames = bytes.Length / bufferLength;

            ARKitFacialValues value = null;

            for (int i = 0; i < totalFrames; i++)
            {

                var buffer = new byte[bufferLength];

                Buffer.BlockCopy(bytes, i * bufferLength, buffer, 0, buffer.Length);

                value = ZeroFormatterSerializer.Deserialize<ARKitFacialValues>(buffer);

                double sec = (double)value.elapsedTicks / Stopwatch.Frequency;

                if (sec >= time)
                {
                    break;
                }


            }

            if (value != null)
            {
                facialControl.ApplyExternal(value);
            }
            else
            {

            }

        }




    }

}