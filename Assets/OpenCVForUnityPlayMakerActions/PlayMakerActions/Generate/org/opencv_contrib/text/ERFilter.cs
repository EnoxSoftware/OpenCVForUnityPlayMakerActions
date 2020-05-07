#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ERFilter : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public ERFilter()
        {

        }

        public ERFilter(OpenCVForUnity.TextModule.ERFilter nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
