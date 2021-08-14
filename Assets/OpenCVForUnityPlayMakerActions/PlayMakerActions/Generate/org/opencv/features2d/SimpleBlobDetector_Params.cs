using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SimpleBlobDetector_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public SimpleBlobDetector_Params()
        {

        }

        public SimpleBlobDetector_Params(OpenCVForUnity.Features2dModule.SimpleBlobDetector_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
