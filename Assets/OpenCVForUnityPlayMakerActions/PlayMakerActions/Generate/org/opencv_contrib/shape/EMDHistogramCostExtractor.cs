using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class EMDHistogramCostExtractor : OpenCVForUnityPlayMakerActions.HistogramCostExtractor
    {

        public EMDHistogramCostExtractor ()
        {

        }

        public EMDHistogramCostExtractor (OpenCVForUnity.ShapeModule.EMDHistogramCostExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
