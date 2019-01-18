using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FarnebackOpticalFlow : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public FarnebackOpticalFlow ()
        {

        }

        public FarnebackOpticalFlow (OpenCVForUnity.VideoModule.FarnebackOpticalFlow nativeObj)
            : base (nativeObj)
        {

        }

    }
}
