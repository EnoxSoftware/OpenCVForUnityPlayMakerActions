#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Callback : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Callback ()
        {

        }

        public Callback (OpenCVForUnity.TextModule.Callback nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
