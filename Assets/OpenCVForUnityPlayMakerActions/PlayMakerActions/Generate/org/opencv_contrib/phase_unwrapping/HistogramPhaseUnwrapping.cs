using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Phase_unwrappingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class HistogramPhaseUnwrapping : OpenCVForUnityPlayMakerActions.PhaseUnwrapping
    {

        public HistogramPhaseUnwrapping()
        {

        }

        public HistogramPhaseUnwrapping(OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping nativeObj) : base(nativeObj)
        {

        }

    }
}
