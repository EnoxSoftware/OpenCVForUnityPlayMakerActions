using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FlannBasedMatcher : OpenCVForUnityPlayMakerActions.DescriptorMatcher
    {

        public FlannBasedMatcher()
        {

        }

        public FlannBasedMatcher(OpenCVForUnity.Features2dModule.FlannBasedMatcher nativeObj) : base(nativeObj)
        {

        }

    }
}
