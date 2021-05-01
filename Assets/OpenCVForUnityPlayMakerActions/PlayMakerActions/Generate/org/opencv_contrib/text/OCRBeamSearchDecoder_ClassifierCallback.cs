#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class OCRBeamSearchDecoder_ClassifierCallback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public OCRBeamSearchDecoder_ClassifierCallback()
        {

        }

        public OCRBeamSearchDecoder_ClassifierCallback(OpenCVForUnity.TextModule.OCRBeamSearchDecoder_ClassifierCallback nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
