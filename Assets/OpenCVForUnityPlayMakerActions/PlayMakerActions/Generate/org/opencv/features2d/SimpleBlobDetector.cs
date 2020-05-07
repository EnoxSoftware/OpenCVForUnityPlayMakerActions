using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SimpleBlobDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public SimpleBlobDetector()
        {

        }

        public SimpleBlobDetector(OpenCVForUnity.Features2dModule.SimpleBlobDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
