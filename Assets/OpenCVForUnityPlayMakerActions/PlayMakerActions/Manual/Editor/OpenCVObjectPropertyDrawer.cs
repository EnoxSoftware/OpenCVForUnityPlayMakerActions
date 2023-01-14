using System;
using UnityEngine;
using UnityEditor;
using HutongGames.PlayMakerEditor;
using Object = UnityEngine.Object;

//using OpenCVForUnityPlayMakerActions;

namespace OpenCVForUnityPlayMakerActions
{

    // Test with action that uses an FsmObject variable of AudioClip type. E.g., Set Audio Clip
    [ObjectPropertyDrawer(typeof(OpenCVForUnityPlayMakerActions.OpenCVObject))]
    public class OpenCVObjectPropertyDrawer : ObjectPropertyDrawer
    {
        public override Object OnGUI(GUIContent label, Object obj, bool isSceneObject, params object[] attributes)
        {

            if (obj is OpenCVObject)
            {
                GUILayout.BeginVertical();


                EditorGUILayout.LabelField(label);

                EditorGUI.indentLevel++;

                OpenCVObject opencvObject = obj as OpenCVObject;

                if (opencvObject.wrappedObject != null)
                {
                    EditorGUILayout.SelectableLabel(opencvObject.wrappedObject.ToString());
                }

                EditorGUI.indentLevel--;

                GUILayout.EndVertical();
            }
            else
            {

                GUILayout.BeginHorizontal();

                EditorGUILayout.LabelField(label);
                EditorGUILayout.LabelField("null", GUILayout.MinWidth(20));

                GUILayout.EndHorizontal();
            }

            return obj;
        }
    }
}
