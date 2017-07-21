using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class PredictCollector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public PredictCollector ()
        {

        }

        public PredictCollector (OpenCVForUnity.PredictCollector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
