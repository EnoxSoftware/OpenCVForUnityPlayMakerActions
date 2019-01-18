using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorCNT : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorCNT ()
        {

        }

        public BackgroundSubtractorCNT (OpenCVForUnity.BgsegmModule.BackgroundSubtractorCNT nativeObj)
            : base (nativeObj)
        {

        }

    }
}
