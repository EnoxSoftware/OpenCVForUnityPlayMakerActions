using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BriefDescriptorExtractor : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public BriefDescriptorExtractor ()
        {

        }

        public BriefDescriptorExtractor (OpenCVForUnity.Xfeatures2dModule.BriefDescriptorExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
