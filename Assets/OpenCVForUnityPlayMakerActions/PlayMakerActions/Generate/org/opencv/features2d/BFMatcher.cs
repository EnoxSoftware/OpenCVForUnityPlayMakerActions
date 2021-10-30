using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BFMatcher : OpenCVForUnityPlayMakerActions.DescriptorMatcher
    {

        public BFMatcher()
        {

        }

        public BFMatcher(OpenCVForUnity.Features2dModule.BFMatcher nativeObj) : base(nativeObj)
        {

        }

    }
}
