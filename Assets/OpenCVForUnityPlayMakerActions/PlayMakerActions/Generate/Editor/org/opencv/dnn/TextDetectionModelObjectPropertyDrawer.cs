#if !UNITY_WSA_10_0
using System;
using UnityEngine;
using UnityEditor;
using HutongGames.PlayMakerEditor;
using Object = UnityEngine.Object;

namespace OpenCVForUnityPlayMakerActions
{

    // Test with action that uses an FsmObject variable of AudioClip type. E.g., Set Audio Clip

    [ObjectPropertyDrawer(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel))]
    public class TextDetectionModelObjectPropertyDrawer : OpenCVObjectPropertyDrawer
    {

    }
}
#endif
