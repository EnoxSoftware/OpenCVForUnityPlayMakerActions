#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class OCRHMMDecoder_ClassifierCallback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public OCRHMMDecoder_ClassifierCallback()
        {

        }

        public OCRHMMDecoder_ClassifierCallback(OpenCVForUnity.TextModule.OCRHMMDecoder_ClassifierCallback nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
