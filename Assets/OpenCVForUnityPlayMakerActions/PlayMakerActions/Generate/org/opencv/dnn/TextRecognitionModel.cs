#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TextRecognitionModel : OpenCVForUnityPlayMakerActions.Model
    {

        public TextRecognitionModel()
        {

        }

        public TextRecognitionModel(OpenCVForUnity.DnnModule.TextRecognitionModel nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
