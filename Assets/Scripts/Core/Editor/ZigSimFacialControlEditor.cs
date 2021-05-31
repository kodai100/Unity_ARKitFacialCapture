using UnityEngine;
using UnityEditor;
using System;

namespace ProjectBlue.FacialCapture.Core
{

    [CustomEditor(typeof(ARKitFacialControl))]
    public class ARKitFacialControlEditor : Editor
    {

        ARKitFacialControl script;

        private SerializedProperty faceSkinProperty;

        bool folding = false;

        private int offset;

        private void OnEnable()
        {
            script = target as ARKitFacialControl;

            faceSkinProperty = serializedObject.FindProperty("skin");

            InitializeSkin();
        }

        public override void OnInspectorGUI()
        {

            serializedObject.Update();

            using (new EditorGUILayout.VerticalScope())
            {

                EditorGUILayout.PropertyField(faceSkinProperty);


                if (GUILayout.Button("Update"))
                {
                    ResetParameters();
                    InitializeSkin();
                }

                
                if (script.skin)
                {

                    if (folding = EditorGUILayout.Foldout(folding, "Blend Shape Mappings"))
                    {
                        using (new EditorGUILayout.VerticalScope())
                        {

                            using (new EditorGUILayout.HorizontalScope())
                            {
                                offset= EditorGUILayout.IntField(offset);
                                if (GUILayout.Button("Map with offset"))
                                {
                                    Map(offset);
                                }
                            }
                            
                            for (int i = 0; i < Enum.GetValues(typeof(ARKitBlendShape)).Length; i++)
                            {

                                if (script.blendShapeList.Count <= 0) break;

                                using (new EditorGUI.IndentLevelScope(1))
                                {
                                    using (new EditorGUILayout.HorizontalScope())
                                    {
                                        EditorGUILayout.LabelField(Enum.GetValues(typeof(ARKitBlendShape)).GetValue(i).ToString());

                                        script.indexList[i] = EditorGUILayout.Popup(script.indexList[i], script.blendShapeList.ToArray());

                                        script.strengthMultiplierList[i] = EditorGUILayout.FloatField(script.strengthMultiplierList[i]);
                                    }
                                }


                            }
                        }
                    }

                }

            }

            serializedObject.ApplyModifiedProperties();
        }

        void InitializeSkin()
        {

            if (!script.skin) return;

            script.blendShapeList.Clear();

            script.blendShapeList.Add("None");

            for (int i = 0; i < script.skin.sharedMesh.blendShapeCount; i++)
            {
                script.blendShapeList.Add(script.skin.sharedMesh.GetBlendShapeName(i));
            }

        }

        void ResetParameters()
        {

            for (int i = 0; i < Enum.GetNames(typeof(ARKitBlendShape)).Length; i++)
            {

                script.indexList[i] = 0;

            }

            for (int i = 0; i < script.strengthMultiplierList.Length; i++)
            {
                if (script.strengthMultiplierList[i] == 0)
                {
                    script.strengthMultiplierList[i] = 1;
                }
            }

        }

        private void Map(int offset)
        {
            for (var i = 0; i < Enum.GetNames(typeof(ARKitBlendShape)).Length; i++)
            {
                if (i + (offset+1) < Enum.GetNames(typeof(ARKitBlendShape)).Length)
                {
                    script.indexList[i] = i + (offset+1);
                }
                else
                {
                    script.indexList[i] = 0;
                }

            }
        }
    }

}