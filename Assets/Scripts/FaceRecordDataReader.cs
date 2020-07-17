using ProjectBlue.FacialCapture;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEngine.Timeline;
using ZeroFormatter;

using Debug = UnityEngine.Debug;

public class FaceRecordDataReader : MonoBehaviour, ITimeControl
{

    static readonly int bufferLength = 436;

    [SerializeField]
    ZigSimFacialControl facialControl;

    [SerializeField]
    TextAsset asset;

    public void OnControlTimeStart()
    {
        //throw new NotImplementedException();

        ZeroFormatterInitializer.Register();
    }

    public void OnControlTimeStop()
    {
        //throw new NotImplementedException();
    }

    public void SetTime(double time)
    {
        //throw new NotImplementedException();


        if (!asset) return;



        var bytes = asset.bytes;
        int totalFrames = bytes.Length / bufferLength;

        ARKitFacialValues value = null;

        for (int i = 0; i < totalFrames; i++)
        {

            var buffer = new byte[bufferLength];

            Buffer.BlockCopy(bytes, i * bufferLength, buffer, 0, buffer.Length);

            value = ZeroFormatterSerializer.Deserialize<ARKitFacialValues>(buffer);

            double sec = (double) value.elapsedTicks / Stopwatch.Frequency;

            if(sec >= time)
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
