using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class DetectorParameters : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public DetectorParameters ()
        {

        }

        public DetectorParameters (OpenCVForUnity.DetectorParameters nativeObj)
            : base (nativeObj)
        {

        }

    }
}
