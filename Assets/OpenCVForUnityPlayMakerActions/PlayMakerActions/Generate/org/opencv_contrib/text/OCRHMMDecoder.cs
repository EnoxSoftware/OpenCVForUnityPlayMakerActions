#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class OCRHMMDecoder : OpenCVForUnityPlayMakerActions.BaseOCR
    {

        public OCRHMMDecoder()
        {

        }

        public OCRHMMDecoder(OpenCVForUnity.TextModule.OCRHMMDecoder nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
