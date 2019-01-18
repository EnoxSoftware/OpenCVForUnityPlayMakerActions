using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorGMG : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorGMG ()
        {

        }

        public BackgroundSubtractorGMG (OpenCVForUnity.BgsegmModule.BackgroundSubtractorGMG nativeObj)
            : base (nativeObj)
        {

        }

    }
}
