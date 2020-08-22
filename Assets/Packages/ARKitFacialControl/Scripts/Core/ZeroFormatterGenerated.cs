#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;
    using global::ZeroFormatter.Comparers;
    public static partial class ZeroFormatterInitializer
    {
        static bool registered = false;

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Register()
        {
            if(registered) return;
            registered = true;
            // Enums
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape>.Register(new ZeroFormatter.DynamicObjectSegments.ProjectBlue.FacialCapture.ARKitBlendShapeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::ProjectBlue.FacialCapture.Core.ARKitBlendShape>.Register(new ZeroFormatter.DynamicObjectSegments.ProjectBlue.FacialCapture.ARKitBlendShapeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape?>.Register(new ZeroFormatter.DynamicObjectSegments.ProjectBlue.FacialCapture.NullableARKitBlendShapeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::ProjectBlue.FacialCapture.Core.ARKitBlendShape?>.Register(new NullableEqualityComparer<global::ProjectBlue.FacialCapture.Core.ARKitBlendShape>());
            
            // Objects
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::ProjectBlue.FacialCapture.Core.ARKitFacialValues>.Register(new ZeroFormatter.DynamicObjectSegments.ARKitFacialValuesFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            // Structs
            // Unions
            // Generics
        }
    }
}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments
{
    using global::System;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;

    public class ARKitFacialValuesFormatter<TTypeResolver> : Formatter<TTypeResolver, global::ProjectBlue.FacialCapture.Core.ARKitFacialValues>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::ProjectBlue.FacialCapture.Core.ARKitFacialValues value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (52 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 0, value.noseSneer_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 1, value.noseSneer_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 2, value.mouthUpperUp_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 3, value.mouthUpperUp_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 4, value.mouthLowerDown_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 5, value.mouthLowerDown_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 6, value.mouthPress_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 7, value.mouthPress_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 8, value.mouthStretch_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 9, value.mouthStretch_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 10, value.mouth_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 11, value.mouth_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 12, value.mouthDimple_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 13, value.mouthDimple_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 14, value.mouthFrown_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 15, value.mouthFrown_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 16, value.mouthFunnel);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 17, value.mouthPucker);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 18, value.mouthSmile_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 19, value.mouthSmile_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 20, value.mouthClose);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 21, value.jaw_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 22, value.jaw_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 23, value.jawOpen);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 24, value.jawForward);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 25, value.eyeLookUp_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 26, value.eyeLookUp_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 27, value.eyeLookOut_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 28, value.eyeLookOut_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 29, value.eyeLookIn_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 30, value.eyeLookIn_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 31, value.eyeLookDown_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 32, value.eyeLookDown_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 33, value.eyeSquint_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 34, value.eyeSquint_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 35, value.eyeWide_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 36, value.eyeWide_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 37, value.eyeBlink_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 38, value.eyeBlink_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 39, value.cheekSquint_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 40, value.cheekSquint_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 41, value.cheekPuff);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 42, value.browOuterUp_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 43, value.browOuterUp_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 44, value.browDown_R);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 45, value.browDown_L);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 46, value.browInnerUp);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 47, value.tongueOut);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 48, value.mouthRollLower);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 49, value.mouthRollUpper);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 50, value.mouthShrugLower);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, float>(ref bytes, startOffset, offset, 51, value.mouthShrugUpper);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, long>(ref bytes, startOffset, offset, 52, value.elapsedTicks);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 52);
            }
        }

        public override global::ProjectBlue.FacialCapture.Core.ARKitFacialValues Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new ARKitFacialValuesObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class ARKitFacialValuesObjectSegment<TTypeResolver> : global::ProjectBlue.FacialCapture.Core.ARKitFacialValues, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 8 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;


        // 0
        public override float noseSneer_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 0, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 0, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 1
        public override float noseSneer_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 1, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 2
        public override float mouthUpperUp_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 2, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 2, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 3
        public override float mouthUpperUp_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 3, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 3, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 4
        public override float mouthLowerDown_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 4, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 4, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 5
        public override float mouthLowerDown_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 5, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 5, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 6
        public override float mouthPress_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 6, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 6, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 7
        public override float mouthPress_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 7, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 7, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 8
        public override float mouthStretch_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 8, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 8, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 9
        public override float mouthStretch_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 9, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 9, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 10
        public override float mouth_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 10, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 10, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 11
        public override float mouth_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 11, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 11, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 12
        public override float mouthDimple_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 12, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 12, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 13
        public override float mouthDimple_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 13, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 13, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 14
        public override float mouthFrown_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 14, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 14, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 15
        public override float mouthFrown_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 15, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 15, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 16
        public override float mouthFunnel
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 16, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 16, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 17
        public override float mouthPucker
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 17, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 17, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 18
        public override float mouthSmile_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 18, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 18, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 19
        public override float mouthSmile_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 19, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 19, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 20
        public override float mouthClose
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 20, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 20, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 21
        public override float jaw_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 21, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 21, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 22
        public override float jaw_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 22, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 22, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 23
        public override float jawOpen
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 23, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 23, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 24
        public override float jawForward
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 24, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 24, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 25
        public override float eyeLookUp_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 25, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 25, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 26
        public override float eyeLookUp_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 26, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 26, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 27
        public override float eyeLookOut_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 27, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 27, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 28
        public override float eyeLookOut_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 28, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 28, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 29
        public override float eyeLookIn_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 29, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 29, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 30
        public override float eyeLookIn_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 30, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 30, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 31
        public override float eyeLookDown_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 31, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 31, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 32
        public override float eyeLookDown_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 32, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 32, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 33
        public override float eyeSquint_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 33, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 33, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 34
        public override float eyeSquint_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 34, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 34, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 35
        public override float eyeWide_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 35, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 35, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 36
        public override float eyeWide_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 36, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 36, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 37
        public override float eyeBlink_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 37, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 37, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 38
        public override float eyeBlink_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 38, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 38, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 39
        public override float cheekSquint_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 39, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 39, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 40
        public override float cheekSquint_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 40, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 40, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 41
        public override float cheekPuff
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 41, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 41, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 42
        public override float browOuterUp_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 42, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 42, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 43
        public override float browOuterUp_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 43, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 43, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 44
        public override float browDown_R
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 44, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 44, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 45
        public override float browDown_L
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 45, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 45, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 46
        public override float browInnerUp
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 46, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 46, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 47
        public override float tongueOut
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 47, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 47, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 48
        public override float mouthRollLower
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 48, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 48, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 49
        public override float mouthRollUpper
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 49, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 49, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 50
        public override float mouthShrugLower
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 50, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 50, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 51
        public override float mouthShrugUpper
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, float>(__originalBytes, 51, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, float>(__originalBytes, 51, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 52
        public override long elapsedTicks
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, long>(__originalBytes, 52, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, long>(__originalBytes, 52, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }


        public ARKitFacialValuesObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 52, __elementSizes);

        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (52 + 1));

                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 0, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 1, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 2, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 3, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 4, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 5, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 6, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 7, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 8, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 9, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 10, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 11, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 12, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 13, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 14, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 15, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 16, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 17, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 18, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 19, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 20, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 21, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 22, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 23, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 24, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 25, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 26, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 27, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 28, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 29, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 30, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 31, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 32, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 33, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 34, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 35, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 36, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 37, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 38, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 39, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 40, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 41, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 42, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 43, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 44, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 45, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 46, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 47, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 48, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 49, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 50, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, float>(ref targetBytes, startOffset, offset, 51, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, long>(ref targetBytes, startOffset, offset, 52, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 52);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.ProjectBlue.FacialCapture
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class ARKitBlendShapeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::ProjectBlue.FacialCapture.Core.ARKitBlendShape Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::ProjectBlue.FacialCapture.Core.ARKitBlendShape)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableARKitBlendShapeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::ProjectBlue.FacialCapture.Core.ARKitBlendShape? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::ProjectBlue.FacialCapture.Core.ARKitBlendShape)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class ARKitBlendShapeEqualityComparer : IEqualityComparer<global::ProjectBlue.FacialCapture.Core.ARKitBlendShape>
    {
        public bool Equals(global::ProjectBlue.FacialCapture.Core.ARKitBlendShape x, global::ProjectBlue.FacialCapture.Core.ARKitBlendShape y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::ProjectBlue.FacialCapture.Core.ARKitBlendShape x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
