using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class OpticalFlowPCAFlow : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public OpticalFlowPCAFlow ()
        {

        }

        public OpticalFlowPCAFlow (OpenCVForUnity.OptflowModule.OpticalFlowPCAFlow nativeObj)
            : base (nativeObj)
        {

        }

    }
}
