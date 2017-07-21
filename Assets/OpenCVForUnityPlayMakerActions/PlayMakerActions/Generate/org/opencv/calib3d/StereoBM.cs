using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class StereoBM : OpenCVForUnityPlayMakerActions.StereoMatcher
    {

        public StereoBM ()
        {

        }

        public StereoBM (OpenCVForUnity.StereoBM nativeObj)
            : base (nativeObj)
        {

        }

    }
}
