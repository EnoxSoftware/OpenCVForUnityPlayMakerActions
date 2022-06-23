#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetectionModel_EAST : OpenCVForUnityPlayMakerActions.TextDetectionModel
    {

        public TextDetectionModel_EAST()
        {

        }

        public TextDetectionModel_EAST(OpenCVForUnity.DnnModule.TextDetectionModel_EAST nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
