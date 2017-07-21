using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class MatOfKeyPoint : OpenCVForUnityPlayMakerActions.Mat
    {

        public MatOfKeyPoint ()
        {

        }

        public MatOfKeyPoint (OpenCVForUnity.MatOfKeyPoint nativeObj)
            : base (nativeObj)
        {

        }

    }
}
