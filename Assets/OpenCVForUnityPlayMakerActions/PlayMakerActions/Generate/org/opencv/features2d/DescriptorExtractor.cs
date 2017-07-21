using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class DescriptorExtractor : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public DescriptorExtractor ()
        {

        }

        public DescriptorExtractor (OpenCVForUnity.DescriptorExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
