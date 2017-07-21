using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class EdgeAwareInterpolator : OpenCVForUnityPlayMakerActions.SparseMatchInterpolator
    {

        public EdgeAwareInterpolator ()
        {

        }

        public EdgeAwareInterpolator (OpenCVForUnity.EdgeAwareInterpolator nativeObj)
            : base (nativeObj)
        {

        }

    }
}
