using ProjectBlue.FacialCapture;
using System;
using System.Text;
using ZeroFormatter;

namespace ProjectBlue.FacialCapture.Core
{

    [ZeroFormattable]
    public class ARKitFacialValues
    {
        [Index(0)]
        public virtual Single noseSneer_R { get; set; }
        [Index(1)]
        public virtual Single noseSneer_L { get; set; }
        [Index(2)]
        public virtual Single mouthUpperUp_R { get; set; }
        [Index(3)]
        public virtual Single mouthUpperUp_L { get; set; }
        [Index(4)]
        public virtual Single mouthLowerDown_R { get; set; }
        [Index(5)]
        public virtual Single mouthLowerDown_L { get; set; }
        [Index(6)]
        public virtual Single mouthPress_R { get; set; }
        [Index(7)]
        public virtual Single mouthPress_L { get; set; }
        [Index(8)]
        public virtual Single mouthStretch_R { get; set; }
        [Index(9)]
        public virtual Single mouthStretch_L { get; set; }
        [Index(10)]
        public virtual Single mouth_R { get; set; }
        [Index(11)]
        public virtual Single mouth_L { get; set; }
        [Index(12)]
        public virtual Single mouthDimple_R { get; set; }
        [Index(13)]
        public virtual Single mouthDimple_L { get; set; }
        [Index(14)]
        public virtual Single mouthFrown_R { get; set; }
        [Index(15)]
        public virtual Single mouthFrown_L { get; set; }
        [Index(16)]
        public virtual Single mouthFunnel { get; set; }
        [Index(17)]
        public virtual Single mouthPucker { get; set; }
        [Index(18)]
        public virtual Single mouthSmile_R { get; set; }
        [Index(19)]
        public virtual Single mouthSmile_L { get; set; }
        [Index(20)]
        public virtual Single mouthClose { get; set; }
        [Index(21)]
        public virtual Single jaw_R { get; set; }
        [Index(22)]
        public virtual Single jaw_L { get; set; }
        [Index(23)]
        public virtual Single jawOpen { get; set; }
        [Index(24)]
        public virtual Single jawForward { get; set; }
        [Index(25)]
        public virtual Single eyeLookUp_R { get; set; }
        [Index(26)]
        public virtual Single eyeLookUp_L { get; set; }
        [Index(27)]
        public virtual Single eyeLookOut_R { get; set; }
        [Index(28)]
        public virtual Single eyeLookOut_L { get; set; }
        [Index(29)]
        public virtual Single eyeLookIn_R { get; set; }
        [Index(30)]
        public virtual Single eyeLookIn_L { get; set; }
        [Index(31)]
        public virtual Single eyeLookDown_R { get; set; }
        [Index(32)]
        public virtual Single eyeLookDown_L { get; set; }
        [Index(33)]
        public virtual Single eyeSquint_R { get; set; }
        [Index(34)]
        public virtual Single eyeSquint_L { get; set; }
        [Index(35)]
        public virtual Single eyeWide_R { get; set; }
        [Index(36)]
        public virtual Single eyeWide_L { get; set; }
        [Index(37)]
        public virtual Single eyeBlink_R { get; set; }
        [Index(38)]
        public virtual Single eyeBlink_L { get; set; }
        [Index(39)]
        public virtual Single cheekSquint_R { get; set; }
        [Index(40)]
        public virtual Single cheekSquint_L { get; set; }
        [Index(41)]
        public virtual Single cheekPuff { get; set; }
        [Index(42)]
        public virtual Single browOuterUp_R { get; set; }
        [Index(43)]
        public virtual Single browOuterUp_L { get; set; }
        [Index(44)]
        public virtual Single browDown_R { get; set; }
        [Index(45)]
        public virtual Single browDown_L { get; set; }
        [Index(46)]
        public virtual Single browInnerUp { get; set; }
        [Index(47)]
        public virtual Single tongueOut { get; set; }
        [Index(48)]
        public virtual Single mouthRollLower { get; set; }
        [Index(49)]
        public virtual Single mouthRollUpper { get; set; }
        [Index(50)]
        public virtual Single mouthShrugLower { get; set; }
        [Index(51)]
        public virtual Single mouthShrugUpper { get; set; }

        [Index(52)]
        public virtual Int64 elapsedTicks { get; set; }


        public void SetValueFromIndex(int index, float value)
        {

            switch (index)
            {
                case 0:
                    noseSneer_R = value;
                    break;
                case 1:
                    noseSneer_L = value;
                    break;
                case 2:
                    mouthUpperUp_R = value;
                    break;
                case 3:
                    mouthUpperUp_L = value;
                    break;
                case 4:
                    mouthLowerDown_R = value;
                    break;
                case 5:
                    mouthLowerDown_L = value;
                    break;
                case 6:
                    mouthPress_R = value;
                    break;
                case 7:
                    mouthPress_L = value;
                    break;
                case 8:
                    mouthStretch_R = value;
                    break;
                case 9:
                    mouthStretch_L = value;
                    break;
                case 10:
                    mouth_R = value;
                    break;
                case 11:
                    mouth_L = value;
                    break;
                case 12:
                    mouthDimple_R = value;
                    break;
                case 13:
                    mouthDimple_L = value;
                    break;
                case 14:
                    mouthFrown_R = value;
                    break;
                case 15:
                    mouthFrown_L = value;
                    break;
                case 16:
                    mouthFunnel = value;
                    break;
                case 17:
                    mouthPucker = value;
                    break;
                case 18:
                    mouthSmile_R = value;
                    break;
                case 19:
                    mouthSmile_L = value;
                    break;
                case 20:
                    mouthClose = value;
                    break;
                case 21:
                    jaw_R = value;
                    break;
                case 22:
                    jaw_L = value;
                    break;
                case 23:
                    jawOpen = value;
                    break;
                case 24:
                    jawForward = value;
                    break;
                case 25:
                    eyeLookUp_R = value;
                    break;
                case 26:
                    eyeLookUp_L = value;
                    break;
                case 27:
                    eyeLookOut_R = value;
                    break;
                case 28:
                    eyeLookOut_L = value;
                    break;
                case 29:
                    eyeLookIn_R = value;
                    break;
                case 30:
                    eyeLookIn_L = value;
                    break;
                case 31:
                    eyeLookDown_R = value;
                    break;
                case 32:
                    eyeLookDown_L = value;
                    break;
                case 33:
                    eyeSquint_R = value;
                    break;
                case 34:
                    eyeSquint_L = value;
                    break;
                case 35:
                    eyeWide_R = value;
                    break;
                case 36:
                    eyeWide_L = value;
                    break;
                case 37:
                    eyeBlink_R = value;
                    break;
                case 38:
                    eyeBlink_L = value;
                    break;
                case 39:
                    cheekSquint_R = value;
                    break;
                case 40:
                    cheekSquint_L = value;
                    break;
                case 41:
                    cheekPuff = value;
                    break;
                case 42:
                    browOuterUp_R = value;
                    break;
                case 43:
                    browOuterUp_L = value;
                    break;
                case 44:
                    browDown_R = value;
                    break;
                case 45:
                    browDown_L = value;
                    break;
                case 46:
                    browInnerUp = value;
                    break;
                case 47:
                    tongueOut = value;
                    break;
                case 48:
                    mouthRollLower = value;
                    break;
                case 49:
                    mouthRollUpper = value;
                    break;
                case 50:
                    mouthShrugLower = value;
                    break;
                case 51:
                    mouthShrugUpper = value;
                    break;
            }


        }

        public float GetValueFromIndex(int index)
        {

            switch (index)
            {
                case 0:
                    return noseSneer_R;
                case 1:
                    return noseSneer_L;
                case 2:
                    return mouthUpperUp_R;
                case 3:
                    return mouthUpperUp_L;
                case 4:
                    return mouthLowerDown_R;
                case 5:
                    return mouthLowerDown_L;
                case 6:
                    return mouthPress_R;
                case 7:
                    return mouthPress_L;
                case 8:
                    return mouthStretch_R;
                case 9:
                    return mouthStretch_L;
                case 10:
                    return mouth_R;
                case 11:
                    return mouth_L;
                case 12:
                    return mouthDimple_R;
                case 13:
                    return mouthDimple_L;
                case 14:
                    return mouthFrown_R;
                case 15:
                    return mouthFrown_L;
                case 16:
                    return mouthFunnel;
                case 17:
                    return mouthPucker;
                case 18:
                    return mouthSmile_R;
                case 19:
                    return mouthSmile_L;
                case 20:
                    return mouthClose;
                case 21:
                    return jaw_R;
                case 22:
                    return jaw_L;
                case 23:
                    return jawOpen;
                case 24:
                    return jawForward;
                case 25:
                    return eyeLookUp_R;
                case 26:
                    return eyeLookUp_L;
                case 27:
                    return eyeLookOut_R;
                case 28:
                    return eyeLookOut_L;
                case 29:
                    return eyeLookIn_R;
                case 30:
                    return eyeLookIn_L;
                case 31:
                    return eyeLookDown_R;
                case 32:
                    return eyeLookDown_L;
                case 33:
                    return eyeSquint_R;
                case 34:
                    return eyeSquint_L;
                case 35:
                    return eyeWide_R;
                case 36:
                    return eyeWide_L;
                case 37:
                    return eyeBlink_R;
                case 38:
                    return eyeBlink_L;
                case 39:
                    return cheekSquint_R;
                case 40:
                    return cheekSquint_L;
                case 41:
                    return cheekPuff;
                case 42:
                    return browOuterUp_R;
                case 43:
                    return browOuterUp_L;
                case 44:
                    return browDown_R;
                case 45:
                    return browDown_L;
                case 46:
                    return browInnerUp;
                case 47:
                    return tongueOut;
                case 48:
                    return mouthRollLower;
                case 49:
                    return mouthRollUpper;
                case 50:
                    return mouthShrugLower;
                case 51:
                    return mouthShrugUpper;
                default:
                    return 0;
            }

        }


        public string ToString()
        {

            StringBuilder builder = new StringBuilder();

            foreach (ARKitBlendShape blendShapeType in Enum.GetValues(typeof(ARKitBlendShape)))
            {
                int index = (int)blendShapeType;
                float value = GetValueFromIndex(index);

                string name = Enum.GetName(typeof(ARKitBlendShape), blendShapeType);

                builder.Append($"{name} : {value.ToString()}\n");
            }

            return builder.ToString();
        }


    }

}