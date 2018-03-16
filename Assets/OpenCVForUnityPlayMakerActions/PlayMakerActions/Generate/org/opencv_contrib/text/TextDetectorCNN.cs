#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetectorCNN : OpenCVForUnityPlayMakerActions.TextDetector
    {

        public TextDetectorCNN ()
        {

        }

        public TextDetectorCNN (OpenCVForUnity.TextDetectorCNN nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
