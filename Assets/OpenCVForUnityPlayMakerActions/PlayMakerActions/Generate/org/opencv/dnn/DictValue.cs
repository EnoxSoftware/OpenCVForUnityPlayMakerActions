#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DictValue : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public DictValue()
        {

        }

        public DictValue(OpenCVForUnity.DnnModule.DictValue nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
