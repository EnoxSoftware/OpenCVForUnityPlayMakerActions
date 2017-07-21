using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Mat : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Mat ()
        {

        }

        public Mat (OpenCVForUnity.Mat nativeObj)
            : base (nativeObj)
        {

        }

    }
}
