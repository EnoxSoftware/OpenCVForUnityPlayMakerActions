#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetectionModel : OpenCVForUnityPlayMakerActions.Model
    {

        public TextDetectionModel()
        {

        }

        public TextDetectionModel(OpenCVForUnity.DnnModule.TextDetectionModel nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
