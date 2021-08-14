#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class OCRBeamSearchDecoder : OpenCVForUnityPlayMakerActions.BaseOCR
    {

        public OCRBeamSearchDecoder()
        {

        }

        public OCRBeamSearchDecoder(OpenCVForUnity.TextModule.OCRBeamSearchDecoder nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
