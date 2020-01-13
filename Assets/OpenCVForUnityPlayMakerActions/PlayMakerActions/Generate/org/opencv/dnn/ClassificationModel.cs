#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ClassificationModel : OpenCVForUnityPlayMakerActions.Model
    {

        public ClassificationModel()
        {

        }

        public ClassificationModel(OpenCVForUnity.DnnModule.ClassificationModel nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
