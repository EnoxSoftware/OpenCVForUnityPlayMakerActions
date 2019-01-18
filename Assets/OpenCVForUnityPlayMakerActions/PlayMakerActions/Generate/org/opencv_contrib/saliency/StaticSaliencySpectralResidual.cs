using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StaticSaliencySpectralResidual : OpenCVForUnityPlayMakerActions.StaticSaliency
    {

        public StaticSaliencySpectralResidual ()
        {

        }

        public StaticSaliencySpectralResidual (OpenCVForUnity.SaliencyModule.StaticSaliencySpectralResidual nativeObj)
            : base (nativeObj)
        {

        }

    }
}
