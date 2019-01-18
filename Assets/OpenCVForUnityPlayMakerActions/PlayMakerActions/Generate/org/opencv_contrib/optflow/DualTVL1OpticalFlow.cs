using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DualTVL1OpticalFlow : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public DualTVL1OpticalFlow ()
        {

        }

        public DualTVL1OpticalFlow (OpenCVForUnity.OptflowModule.DualTVL1OpticalFlow nativeObj)
            : base (nativeObj)
        {

        }

    }
}
