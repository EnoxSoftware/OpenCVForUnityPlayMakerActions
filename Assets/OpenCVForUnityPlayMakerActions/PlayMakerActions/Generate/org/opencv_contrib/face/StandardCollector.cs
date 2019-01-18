using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StandardCollector : OpenCVForUnityPlayMakerActions.PredictCollector
    {

        public StandardCollector ()
        {

        }

        public StandardCollector (OpenCVForUnity.FaceModule.StandardCollector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
