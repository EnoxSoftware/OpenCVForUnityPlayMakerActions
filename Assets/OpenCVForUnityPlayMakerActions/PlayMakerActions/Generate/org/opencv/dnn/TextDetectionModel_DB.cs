#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TextDetectionModel_DB : OpenCVForUnityPlayMakerActions.TextDetectionModel
    {

        public TextDetectionModel_DB()
        {

        }

        public TextDetectionModel_DB(OpenCVForUnity.DnnModule.TextDetectionModel_DB nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
