using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DescriptorMatcher : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public DescriptorMatcher()
        {

        }

        public DescriptorMatcher(OpenCVForUnity.Features2dModule.DescriptorMatcher nativeObj) : base(nativeObj)
        {

        }

    }
}
