using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class BOWImgDescriptorExtractor : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BOWImgDescriptorExtractor ()
        {

        }

        public BOWImgDescriptorExtractor (OpenCVForUnity.BOWImgDescriptorExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
