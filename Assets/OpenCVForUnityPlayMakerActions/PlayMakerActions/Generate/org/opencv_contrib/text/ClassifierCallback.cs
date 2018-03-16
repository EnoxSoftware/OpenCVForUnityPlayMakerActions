#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class ClassifierCallback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public ClassifierCallback ()
        {

        }

        public ClassifierCallback (OpenCVForUnity.ClassifierCallback nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
