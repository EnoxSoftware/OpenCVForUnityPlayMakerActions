using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ChiHistogramCostExtractor : OpenCVForUnityPlayMakerActions.HistogramCostExtractor
    {

        public ChiHistogramCostExtractor ()
        {

        }

        public ChiHistogramCostExtractor (OpenCVForUnity.ShapeModule.ChiHistogramCostExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
