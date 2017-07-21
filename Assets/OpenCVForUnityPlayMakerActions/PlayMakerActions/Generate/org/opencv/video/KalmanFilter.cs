using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class KalmanFilter : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public KalmanFilter ()
        {

        }

        public KalmanFilter (OpenCVForUnity.KalmanFilter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
