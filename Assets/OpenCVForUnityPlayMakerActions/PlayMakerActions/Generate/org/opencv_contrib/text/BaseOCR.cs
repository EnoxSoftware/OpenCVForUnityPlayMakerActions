#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BaseOCR : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BaseOCR()
        {

        }

        public BaseOCR(OpenCVForUnity.TextModule.BaseOCR nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
