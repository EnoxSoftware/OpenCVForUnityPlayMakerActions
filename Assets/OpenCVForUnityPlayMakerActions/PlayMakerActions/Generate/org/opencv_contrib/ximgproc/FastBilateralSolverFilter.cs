using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FastBilateralSolverFilter : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public FastBilateralSolverFilter ()
        {

        }

        public FastBilateralSolverFilter (OpenCVForUnity.XimgprocModule.FastBilateralSolverFilter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
