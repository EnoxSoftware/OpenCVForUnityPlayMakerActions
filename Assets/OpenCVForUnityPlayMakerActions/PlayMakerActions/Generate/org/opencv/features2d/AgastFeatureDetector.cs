using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class AgastFeatureDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public AgastFeatureDetector()
        {

        }

        public AgastFeatureDetector(OpenCVForUnity.Features2dModule.AgastFeatureDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
