using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class EdgeAwareInterpolator : OpenCVForUnityPlayMakerActions.SparseMatchInterpolator
    {

        public EdgeAwareInterpolator ()
        {

        }

        public EdgeAwareInterpolator (OpenCVForUnity.XimgprocModule.EdgeAwareInterpolator nativeObj)
            : base (nativeObj)
        {

        }

    }
}
