using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class FastFeatureDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public FastFeatureDetector ()
        {

        }

        public FastFeatureDetector (OpenCVForUnity.FastFeatureDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
