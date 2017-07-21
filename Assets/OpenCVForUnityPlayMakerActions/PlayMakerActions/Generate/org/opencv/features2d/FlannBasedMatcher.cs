using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class FlannBasedMatcher : OpenCVForUnityPlayMakerActions.DescriptorMatcher
    {

        public FlannBasedMatcher ()
        {

        }

        public FlannBasedMatcher (OpenCVForUnity.FlannBasedMatcher nativeObj)
            : base (nativeObj)
        {

        }

    }
}
