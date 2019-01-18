using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.PhotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CalibrateRobertson : OpenCVForUnityPlayMakerActions.CalibrateCRF
    {

        public CalibrateRobertson ()
        {

        }

        public CalibrateRobertson (OpenCVForUnity.PhotoModule.CalibrateRobertson nativeObj)
            : base (nativeObj)
        {

        }

    }
}
