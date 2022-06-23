#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DetectionModel : OpenCVForUnityPlayMakerActions.Model
    {

        public DetectionModel()
        {

        }

        public DetectionModel(OpenCVForUnity.DnnModule.DetectionModel nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
