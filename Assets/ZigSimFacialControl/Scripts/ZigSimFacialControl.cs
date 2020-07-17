using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Osc;
using System;
using UniRx;

namespace ProjectBlue.FacialCapture
{

    using NetworkCommunication;


    public class ZigSimFacialControl : MonoBehaviour
    {

        public int port = 8888;

        public SkinnedMeshRenderer skin;

        public Text text;

        // For editor
        public List<string> blendShapeList = new List<string>();
        public int[] indexList = new int[Enum.GetNames(typeof(ARKitBlendShape)).Length];
        public float[] strengthMultiplierList = new float[Enum.GetNames(typeof(ARKitBlendShape)).Length];

        private Queue<Message> messageQueue = new Queue<Message>();

        
        ARKitFacialValues arkitFacialValues;

        ARKitFacialRecorder recorder;
        ARKitToBlendshapeRemapper remapper;

        private void Start()
        {

            arkitFacialValues = new ARKitFacialValues();

            recorder = new ARKitFacialRecorder();

            remapper = new ARKitToBlendshapeRemapper(skin, blendShapeList, indexList, strengthMultiplierList);

            Parser oscParser = new Parser();

            var server = new UdpServerProxy<Queue<Message>>(port, (bytes, endPoint) =>
            {

                oscParser.FeedData(bytes, bytes.Length);

                messageQueue.Clear();

                while (0 < oscParser.MessageCount)
                {
                    var msg = oscParser.PopMessage();

                    messageQueue.Enqueue(msg);
                }

                return messageQueue;

            });

            server.OnValueChanged()
                .SubscribeOn(Scheduler.ThreadPool)
                .Subscribe()
                .AddTo(this);

            Observable
                .EveryUpdate()
                .Where(_ => messageQueue.Count > 0)
                .Subscribe(_ =>
                {

                    for (int i = 0; i < messageQueue.Count; i++)
                    {
                        OnReceivedOsc(messageQueue.Dequeue());
                    }


                }).AddTo(this);

            Observable
                .EveryUpdate()
                .Subscribe(_ =>
                {

                    recorder.RecordUpdate(arkitFacialValues);
                    remapper.Apply(arkitFacialValues);

                    text.text = arkitFacialValues.ToString();

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

        public void ApplyExternal(ARKitFacialValues arkitFacialValues)
        {
            if(remapper == null)
            {
                remapper = new ARKitToBlendshapeRemapper(skin, blendShapeList, indexList, strengthMultiplierList);
            }

            remapper.Apply(arkitFacialValues);
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

                        var arkitBlendShapeType = ARKitBlendShapeUtil.ARKitBlendShapeDictionary[param.Replace("face", string.Empty)];

                        int targetBlendShapeIndex = indexList[(int)arkitBlendShapeType];

                        string targetBlendShapeName = blendShapeList[targetBlendShapeIndex];

                        var index = skin.sharedMesh.GetBlendShapeIndex(targetBlendShapeName);

                        if (index > -1)
                        {
                            arkitFacialValues.SetValueFromIndex((int)arkitBlendShapeType, Mathf.Min(100, (float)msg.data[0] * 100 * strengthMultiplierList[(int)arkitBlendShapeType]));

                        }

                    }

                }

            }
            catch(Exception e)
            {

            }
            

        }

        

    }

}