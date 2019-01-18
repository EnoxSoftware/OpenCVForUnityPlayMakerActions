using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class KalmanFilter : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public KalmanFilter ()
        {

        }

        public KalmanFilter (OpenCVForUnity.VideoModule.KalmanFilter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
