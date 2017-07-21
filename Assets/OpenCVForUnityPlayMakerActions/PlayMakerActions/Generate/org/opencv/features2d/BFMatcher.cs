using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class BFMatcher : OpenCVForUnityPlayMakerActions.DescriptorMatcher
    {

        public BFMatcher ()
        {

        }

        public BFMatcher (OpenCVForUnity.BFMatcher nativeObj)
            : base (nativeObj)
        {

        }

    }
}
