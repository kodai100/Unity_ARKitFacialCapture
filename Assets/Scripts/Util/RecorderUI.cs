using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UniRx;

namespace ProjectBlue.FacialCapture
{

    using Core;

    public class RecorderUI : MonoBehaviour
    {

        [SerializeField]
        Button recordButton;

        [SerializeField]
        Button stopButton;

        [SerializeField]
        ZigSimFacialControl zigSimFacialControl;


        void Start()
        {


            recordButton.OnClickAsObservable().Subscribe(_ =>
            {
                zigSimFacialControl.StartRecording();

            }).AddTo(this);


            stopButton.OnClickAsObservable().Subscribe(_ =>
            {

                zigSimFacialControl.StopRecording();

            }).AddTo(this);

        }

    }

}

