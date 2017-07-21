using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class MultiTracker : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public MultiTracker ()
        {

        }

        public MultiTracker (OpenCVForUnity.MultiTracker nativeObj)
            : base (nativeObj)
        {

        }

    }
}
