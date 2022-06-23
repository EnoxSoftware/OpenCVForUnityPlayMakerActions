#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class KeypointsModel : OpenCVForUnityPlayMakerActions.Model
    {

        public KeypointsModel()
        {

        }

        public KeypointsModel(OpenCVForUnity.DnnModule.KeypointsModel nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
