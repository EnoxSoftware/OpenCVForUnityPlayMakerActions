using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class RFFeatureGetter : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public RFFeatureGetter ()
        {

        }

        public RFFeatureGetter (OpenCVForUnity.XimgprocModule.RFFeatureGetter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
