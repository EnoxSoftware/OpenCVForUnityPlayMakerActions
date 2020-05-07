using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Calib3dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StereoBM : OpenCVForUnityPlayMakerActions.StereoMatcher
    {

        public StereoBM()
        {

        }

        public StereoBM(OpenCVForUnity.Calib3dModule.StereoBM nativeObj) : base(nativeObj)
        {

        }

    }
}
