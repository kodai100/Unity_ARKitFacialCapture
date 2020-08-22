using ProjectBlue.FacialCapture;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectBlue.FacialCapture.Core
{
    public class ARKitToBlendshapeRemapper
    {

        SkinnedMeshRenderer skin;

        List<string> blendShapeList;
        int[] indexList;
        float[] strengthMultiplierList;

        public ARKitToBlendshapeRemapper(SkinnedMeshRenderer skinnedMeshRenderer, List<string> blendShapeList, int[] indexList, float[] strengthMultiplierList)
        {

            this.skin = skinnedMeshRenderer;

            this.blendShapeList = blendShapeList;
            this.indexList = indexList;
            this.strengthMultiplierList = strengthMultiplierList;

        }

        public void Apply(ARKitFacialValues arkitFacialValues)
        {

            SetWithShapeTypeWith(ARKitBlendShape.noseSneer_R, arkitFacialValues.noseSneer_R);
            SetWithShapeTypeWith(ARKitBlendShape.noseSneer_L, arkitFacialValues.noseSneer_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthUpperUp_R, arkitFacialValues.mouthUpperUp_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthUpperUp_L, arkitFacialValues.mouthUpperUp_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthLowerDown_R, arkitFacialValues.mouthLowerDown_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthLowerDown_L, arkitFacialValues.mouthLowerDown_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthPress_R, arkitFacialValues.mouthPress_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthPress_L, arkitFacialValues.mouthPress_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthStretch_R, arkitFacialValues.mouthStretch_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthStretch_L, arkitFacialValues.mouthStretch_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouth_R, arkitFacialValues.mouth_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouth_L, arkitFacialValues.mouth_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthDimple_R, arkitFacialValues.mouthDimple_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthDimple_L, arkitFacialValues.mouthDimple_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthFrown_R, arkitFacialValues.mouthFrown_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthFrown_L, arkitFacialValues.mouthFrown_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthFunnel, arkitFacialValues.mouthFunnel);
            SetWithShapeTypeWith(ARKitBlendShape.mouthPucker, arkitFacialValues.mouthPucker);

            SetWithShapeTypeWith(ARKitBlendShape.mouthSmile_R, arkitFacialValues.mouthSmile_R);
            SetWithShapeTypeWith(ARKitBlendShape.mouthSmile_L, arkitFacialValues.mouthSmile_L);

            SetWithShapeTypeWith(ARKitBlendShape.mouthClose, arkitFacialValues.mouthClose);

            SetWithShapeTypeWith(ARKitBlendShape.jaw_R, arkitFacialValues.jaw_R);
            SetWithShapeTypeWith(ARKitBlendShape.jaw_L, arkitFacialValues.jaw_L);

            SetWithShapeTypeWith(ARKitBlendShape.jawOpen, arkitFacialValues.jawOpen);
            SetWithShapeTypeWith(ARKitBlendShape.jawForward, arkitFacialValues.jawForward);

            SetWithShapeTypeWith(ARKitBlendShape.eyeLookUp_R, arkitFacialValues.eyeLookUp_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeLookUp_L, arkitFacialValues.eyeLookUp_L);

            SetWithShapeTypeWith(ARKitBlendShape.eyeLookOut_R, arkitFacialValues.eyeLookOut_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeLookOut_L, arkitFacialValues.eyeLookOut_L);

            SetWithShapeTypeWith(ARKitBlendShape.eyeLookIn_R, arkitFacialValues.eyeLookIn_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeLookIn_L, arkitFacialValues.eyeLookIn_L);

            SetWithShapeTypeWith(ARKitBlendShape.eyeLookDown_R, arkitFacialValues.eyeLookDown_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeLookDown_L, arkitFacialValues.eyeLookDown_L);

            SetWithShapeTypeWith(ARKitBlendShape.eyeSquint_R, arkitFacialValues.eyeSquint_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeSquint_L, arkitFacialValues.eyeSquint_L);

            SetWithShapeTypeWith(ARKitBlendShape.eyeWide_R, arkitFacialValues.eyeWide_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeWide_L, arkitFacialValues.eyeWide_L);

            SetWithShapeTypeWith(ARKitBlendShape.eyeBlink_R, arkitFacialValues.eyeBlink_R);
            SetWithShapeTypeWith(ARKitBlendShape.eyeBlink_L, arkitFacialValues.eyeBlink_L);

            SetWithShapeTypeWith(ARKitBlendShape.cheekSquint_R, arkitFacialValues.cheekSquint_R);
            SetWithShapeTypeWith(ARKitBlendShape.cheekSquint_L, arkitFacialValues.cheekSquint_L);

            SetWithShapeTypeWith(ARKitBlendShape.cheekPuff, arkitFacialValues.cheekPuff);

            SetWithShapeTypeWith(ARKitBlendShape.browOuterUp_R, arkitFacialValues.browOuterUp_R);
            SetWithShapeTypeWith(ARKitBlendShape.browOuterUp_L, arkitFacialValues.browOuterUp_L);

            SetWithShapeTypeWith(ARKitBlendShape.browDown_R, arkitFacialValues.browDown_R);
            SetWithShapeTypeWith(ARKitBlendShape.browDown_L, arkitFacialValues.browDown_L);

            SetWithShapeTypeWith(ARKitBlendShape.browInnerUp, arkitFacialValues.browInnerUp);

            SetWithShapeTypeWith(ARKitBlendShape.tongueOut, arkitFacialValues.tongueOut);
            SetWithShapeTypeWith(ARKitBlendShape.mouthRollLower, arkitFacialValues.mouthRollLower);
            SetWithShapeTypeWith(ARKitBlendShape.mouthRollUpper, arkitFacialValues.mouthRollUpper);
            SetWithShapeTypeWith(ARKitBlendShape.mouthShrugLower, arkitFacialValues.mouthShrugLower);
            SetWithShapeTypeWith(ARKitBlendShape.mouthShrugUpper, arkitFacialValues.mouthShrugUpper);

        }

        void SetWithShapeTypeWith(ARKitBlendShape shapeType, float value)
        {
            int targetBlendShapeIndex = indexList[(int)shapeType];
            string targetBlendShapeName = blendShapeList[targetBlendShapeIndex];
            var index = skin.sharedMesh.GetBlendShapeIndex(targetBlendShapeName);

            if (index >= 0)
            {

                skin.SetBlendShapeWeight(index, value);
            }

        }

    }

}