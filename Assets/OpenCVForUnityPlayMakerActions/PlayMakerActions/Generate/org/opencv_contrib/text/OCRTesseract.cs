#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class OCRTesseract : OpenCVForUnityPlayMakerActions.BaseOCR
    {

        public OCRTesseract()
        {

        }

        public OCRTesseract(OpenCVForUnity.TextModule.OCRTesseract nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
