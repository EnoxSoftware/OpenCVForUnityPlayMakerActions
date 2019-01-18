using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class HistogramCostExtractor : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public HistogramCostExtractor ()
        {

        }

        public HistogramCostExtractor (OpenCVForUnity.ShapeModule.HistogramCostExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
