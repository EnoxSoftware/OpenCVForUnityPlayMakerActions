using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class AgastFeatureDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public AgastFeatureDetector ()
        {

        }

        public AgastFeatureDetector (OpenCVForUnity.AgastFeatureDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
