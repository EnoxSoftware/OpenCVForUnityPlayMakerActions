using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BOWImgDescriptorExtractor : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BOWImgDescriptorExtractor()
        {

        }

        public BOWImgDescriptorExtractor(OpenCVForUnity.Features2dModule.BOWImgDescriptorExtractor nativeObj) : base(nativeObj)
        {

        }

    }
}
