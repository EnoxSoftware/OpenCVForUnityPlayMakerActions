#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class OCRBeamSearchDecoder : OpenCVForUnityPlayMakerActions.BaseOCR
    {

        public OCRBeamSearchDecoder ()
        {

        }

        public OCRBeamSearchDecoder (OpenCVForUnity.OCRBeamSearchDecoder nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
