#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class ERFilter : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public ERFilter ()
        {

        }

        public ERFilter (OpenCVForUnity.ERFilter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
