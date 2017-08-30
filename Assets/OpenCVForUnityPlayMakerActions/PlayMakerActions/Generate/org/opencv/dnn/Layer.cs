#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Layer : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public Layer ()
        {

        }

        public Layer (OpenCVForUnity.Layer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
