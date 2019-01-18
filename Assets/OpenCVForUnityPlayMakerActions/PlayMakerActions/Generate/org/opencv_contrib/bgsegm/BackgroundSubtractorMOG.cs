using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorMOG : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorMOG ()
        {

        }

        public BackgroundSubtractorMOG (OpenCVForUnity.BgsegmModule.BackgroundSubtractorMOG nativeObj)
            : base (nativeObj)
        {

        }

    }
}
