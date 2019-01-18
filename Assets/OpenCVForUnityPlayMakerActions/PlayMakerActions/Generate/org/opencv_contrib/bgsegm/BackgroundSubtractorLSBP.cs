using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorLSBP : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorLSBP ()
        {

        }

        public BackgroundSubtractorLSBP (OpenCVForUnity.BgsegmModule.BackgroundSubtractorLSBP nativeObj)
            : base (nativeObj)
        {

        }

    }
}
