using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorLSBPDesc : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BackgroundSubtractorLSBPDesc()
        {

        }

        public BackgroundSubtractorLSBPDesc(OpenCVForUnity.BgsegmModule.BackgroundSubtractorLSBPDesc nativeObj) : base(nativeObj)
        {

        }

    }
}
