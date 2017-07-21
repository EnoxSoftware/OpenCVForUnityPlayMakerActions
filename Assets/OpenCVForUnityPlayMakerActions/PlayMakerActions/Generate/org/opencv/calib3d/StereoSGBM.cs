using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class StereoSGBM : OpenCVForUnityPlayMakerActions.StereoMatcher
    {

        public StereoSGBM ()
        {

        }

        public StereoSGBM (OpenCVForUnity.StereoSGBM nativeObj)
            : base (nativeObj)
        {

        }

    }
}
