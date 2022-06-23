#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Model : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Model()
        {

        }

        public Model(OpenCVForUnity.DnnModule.Model nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
