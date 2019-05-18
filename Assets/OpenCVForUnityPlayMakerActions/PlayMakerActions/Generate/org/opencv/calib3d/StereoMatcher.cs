using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Calib3dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StereoMatcher : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public StereoMatcher()
        {

        }

        public StereoMatcher(OpenCVForUnity.Calib3dModule.StereoMatcher nativeObj) : base(nativeObj)
        {

        }

    }
}
