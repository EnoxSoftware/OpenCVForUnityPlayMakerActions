using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Calib3dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StereoSGBM : OpenCVForUnityPlayMakerActions.StereoMatcher
    {

        public StereoSGBM ()
        {

        }

        public StereoSGBM (OpenCVForUnity.Calib3dModule.StereoSGBM nativeObj)
            : base (nativeObj)
        {

        }

    }
}
