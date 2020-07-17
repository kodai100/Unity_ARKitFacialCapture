using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UniRx;
using ProjectBlue.FacialCapture;

public class RecorderUI : MonoBehaviour
{

    [SerializeField]
    Button recordButton;

    [SerializeField]
    Button stopButton;

    [SerializeField]
    ZigSimFacialControl zigSimFacialControl;

    // Start is called before the first frame update
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
