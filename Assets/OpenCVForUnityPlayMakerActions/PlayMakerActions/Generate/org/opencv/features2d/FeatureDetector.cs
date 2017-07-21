using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class FeatureDetector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public FeatureDetector ()
        {

        }

        public FeatureDetector (OpenCVForUnity.FeatureDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
