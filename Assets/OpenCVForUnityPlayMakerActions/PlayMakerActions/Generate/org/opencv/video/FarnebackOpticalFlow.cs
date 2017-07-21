using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class FarnebackOpticalFlow : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public FarnebackOpticalFlow ()
        {

        }

        public FarnebackOpticalFlow (OpenCVForUnity.FarnebackOpticalFlow nativeObj)
            : base (nativeObj)
        {

        }

    }
}
