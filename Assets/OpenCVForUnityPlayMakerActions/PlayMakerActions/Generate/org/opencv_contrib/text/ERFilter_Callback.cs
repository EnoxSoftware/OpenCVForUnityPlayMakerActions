#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ERFilter_Callback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public ERFilter_Callback()
        {

        }

        public ERFilter_Callback(OpenCVForUnity.TextModule.ERFilter_Callback nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
