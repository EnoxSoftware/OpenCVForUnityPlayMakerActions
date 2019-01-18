#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Net : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Net ()
        {

        }

        public Net (OpenCVForUnity.DnnModule.Net nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
