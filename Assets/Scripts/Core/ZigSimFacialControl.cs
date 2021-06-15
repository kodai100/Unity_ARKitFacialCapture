using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Osc;
using UniRx;
using UnityEngine.UIElements;

namespace ProjectBlue.FacialCapture.Core
{
    using NetworkCommunication;


    public class ZigSimFacialControl : MonoBehaviour
    {
        public int port = 8888;

        public ARKitFacialControl arkitFacialControl;

        public Text text;

        ARKitFacialValues arkitFacialValues;

        ARKitFacialRecorder recorder;

        private void Start()
        {
            arkitFacialValues = new ARKitFacialValues();

            recorder = new ARKitFacialRecorder();

            var oscParser = new Parser();

            var server = new UdpServerProxy(port, (bytes, endPoint) =>
            {
                oscParser.FeedData(bytes, bytes.Length);

                while (0 < oscParser.MessageCount)
                {
                    var msg = oscParser.PopMessage();
                    OnReceivedOsc(msg);
                }
            });

            Observable
                .EveryUpdate()
                .Subscribe(_ =>
                {
                    recorder.RecordUpdate(arkitFacialValues);

                    arkitFacialControl.ApplyExternal(arkitFacialValues);

                    if (text)
                    {
                        text.text = arkitFacialValues.ToString();
                    }
                }).AddTo(this);
        }

        public void StartRecording()
        {
            recorder.StartRecording();
        }

        public void StopRecording()
        {
            recorder.StopRecording();
        }


        public void OnReceivedOsc(Message msg)
        {
            try
            {
                var path = msg.path;

                var pathSplitted = path.Split('/');


                if (pathSplitted.Length == 4)
                {
                    var param = path.Split('/')[3];

                    if (!param.Contains("position") && !param.Contains("rotation"))
                    {
                        var arkitBlendShapeType =
                            ARKitBlendShapeUtil.ARKitBlendShapeDictionary[param.Replace("face", string.Empty)];

                        arkitFacialValues.SetValueFromIndex((int) arkitBlendShapeType,
                            Mathf.Min(100, (float) msg.data[0] * 100));
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}