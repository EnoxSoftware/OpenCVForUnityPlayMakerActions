using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FastFeatureDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public FastFeatureDetector()
        {

        }

        public FastFeatureDetector(OpenCVForUnity.Features2dModule.FastFeatureDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
