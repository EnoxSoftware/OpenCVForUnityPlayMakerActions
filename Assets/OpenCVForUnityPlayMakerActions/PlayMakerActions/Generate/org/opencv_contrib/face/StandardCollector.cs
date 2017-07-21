using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class StandardCollector : OpenCVForUnityPlayMakerActions.PredictCollector
    {

        public StandardCollector ()
        {

        }

        public StandardCollector (OpenCVForUnity.StandardCollector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
