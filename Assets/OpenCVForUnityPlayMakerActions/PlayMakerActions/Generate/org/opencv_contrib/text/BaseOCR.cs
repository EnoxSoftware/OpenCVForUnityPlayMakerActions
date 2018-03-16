#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class BaseOCR : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BaseOCR ()
        {

        }

        public BaseOCR (OpenCVForUnity.BaseOCR nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
