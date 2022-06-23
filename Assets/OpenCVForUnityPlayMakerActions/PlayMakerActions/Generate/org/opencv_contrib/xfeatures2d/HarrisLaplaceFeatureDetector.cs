using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class HarrisLaplaceFeatureDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public HarrisLaplaceFeatureDetector()
        {

        }

        public HarrisLaplaceFeatureDetector(OpenCVForUnity.Xfeatures2dModule.HarrisLaplaceFeatureDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
