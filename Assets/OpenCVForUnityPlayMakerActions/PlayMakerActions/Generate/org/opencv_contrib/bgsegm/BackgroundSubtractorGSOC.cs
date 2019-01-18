using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorGSOC : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorGSOC ()
        {

        }

        public BackgroundSubtractorGSOC (OpenCVForUnity.BgsegmModule.BackgroundSubtractorGSOC nativeObj)
            : base (nativeObj)
        {

        }

    }
}
