#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TextDetector()
        {

        }

        public TextDetector(OpenCVForUnity.TextModule.TextDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
