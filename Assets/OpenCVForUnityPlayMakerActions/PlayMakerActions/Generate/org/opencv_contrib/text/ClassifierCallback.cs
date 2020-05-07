#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ClassifierCallback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public ClassifierCallback()
        {

        }

        public ClassifierCallback(OpenCVForUnity.TextModule.ClassifierCallback nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
