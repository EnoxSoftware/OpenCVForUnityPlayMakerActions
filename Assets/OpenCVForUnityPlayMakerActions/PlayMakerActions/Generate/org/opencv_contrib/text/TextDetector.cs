#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TextDetector ()
        {

        }

        public TextDetector (OpenCVForUnity.TextDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
