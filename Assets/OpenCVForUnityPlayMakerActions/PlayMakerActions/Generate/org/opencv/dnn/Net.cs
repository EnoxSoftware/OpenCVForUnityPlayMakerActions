#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Net : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Net ()
        {

        }

        public Net (OpenCVForUnity.Net nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
