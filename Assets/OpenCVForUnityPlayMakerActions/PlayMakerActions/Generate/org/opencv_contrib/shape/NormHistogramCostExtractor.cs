using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class NormHistogramCostExtractor : OpenCVForUnityPlayMakerActions.HistogramCostExtractor
    {

        public NormHistogramCostExtractor ()
        {

        }

        public NormHistogramCostExtractor (OpenCVForUnity.ShapeModule.NormHistogramCostExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
