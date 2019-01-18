using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class PredictCollector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public PredictCollector ()
        {

        }

        public PredictCollector (OpenCVForUnity.FaceModule.PredictCollector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
