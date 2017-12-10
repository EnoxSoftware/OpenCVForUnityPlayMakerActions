#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class OCRHMMDecoder : OpenCVForUnityPlayMakerActions.BaseOCR
    {

        public OCRHMMDecoder ()
        {

        }

        public OCRHMMDecoder (OpenCVForUnity.OCRHMMDecoder nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
