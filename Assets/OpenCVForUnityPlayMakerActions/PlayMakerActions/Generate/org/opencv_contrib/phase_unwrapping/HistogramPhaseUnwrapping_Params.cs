using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Phase_unwrappingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class HistogramPhaseUnwrapping_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public HistogramPhaseUnwrapping_Params()
        {

        }

        public HistogramPhaseUnwrapping_Params(OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
