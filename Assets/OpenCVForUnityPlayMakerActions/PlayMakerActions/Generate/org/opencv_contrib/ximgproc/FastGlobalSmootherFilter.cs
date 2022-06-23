using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FastGlobalSmootherFilter : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public FastGlobalSmootherFilter()
        {

        }

        public FastGlobalSmootherFilter(OpenCVForUnity.XimgprocModule.FastGlobalSmootherFilter nativeObj) : base(nativeObj)
        {

        }

    }
}
