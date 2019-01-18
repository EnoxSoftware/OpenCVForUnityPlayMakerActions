#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetectorCNN : OpenCVForUnityPlayMakerActions.TextDetector
    {

        public TextDetectorCNN ()
        {

        }

        public TextDetectorCNN (OpenCVForUnity.TextModule.TextDetectorCNN nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
