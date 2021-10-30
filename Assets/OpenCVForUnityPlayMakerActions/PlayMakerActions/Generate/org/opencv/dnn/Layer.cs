#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Layer : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public Layer()
        {

        }

        public Layer(OpenCVForUnity.DnnModule.Layer nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
