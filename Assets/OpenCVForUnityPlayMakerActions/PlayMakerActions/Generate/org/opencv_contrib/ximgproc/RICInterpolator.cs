using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class RICInterpolator : OpenCVForUnityPlayMakerActions.SparseMatchInterpolator
    {

        public RICInterpolator()
        {

        }

        public RICInterpolator(OpenCVForUnity.XimgprocModule.RICInterpolator nativeObj) : base(nativeObj)
        {

        }

    }
}
