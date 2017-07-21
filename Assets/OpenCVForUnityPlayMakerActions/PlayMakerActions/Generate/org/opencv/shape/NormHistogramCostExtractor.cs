using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class NormHistogramCostExtractor : OpenCVForUnityPlayMakerActions.HistogramCostExtractor
    {

        public NormHistogramCostExtractor ()
        {

        }

        public NormHistogramCostExtractor (OpenCVForUnity.NormHistogramCostExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
