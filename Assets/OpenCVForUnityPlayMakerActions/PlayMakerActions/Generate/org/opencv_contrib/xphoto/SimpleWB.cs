using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class SimpleWB : OpenCVForUnityPlayMakerActions.WhiteBalancer
    {

        public SimpleWB ()
        {

        }

        public SimpleWB (OpenCVForUnity.SimpleWB nativeObj)
            : base (nativeObj)
        {

        }

    }
}
