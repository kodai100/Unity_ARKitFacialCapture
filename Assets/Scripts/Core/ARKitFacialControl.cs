using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

namespace ProjectBlue.FacialCapture.Core
{

    public class ARKitFacialControl : MonoBehaviour
    {

        public SkinnedMeshRenderer skin;

        // For editor
        public List<string> blendShapeList = new List<string>();
        public int[] indexList = new int[Enum.GetNames(typeof(ARKitBlendShape)).Length];
        public float[] strengthMultiplierList = new float[Enum.GetNames(typeof(ARKitBlendShape)).Length];


        ARKitToBlendshapeRemapper remapper;

        private void Start()
        {

            remapper = new ARKitToBlendshapeRemapper(skin, blendShapeList, indexList, strengthMultiplierList);

        }

        public void ApplyExternal(ARKitFacialValues arkitFacialValues)
        {
            if(remapper == null)
            {
                remapper = new ARKitToBlendshapeRemapper(skin, blendShapeList, indexList, strengthMultiplierList);
            }

            remapper.Apply(arkitFacialValues);
        }

    }

}