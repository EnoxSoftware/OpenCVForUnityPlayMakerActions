using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TickMeter : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TickMeter ()
        {

        }

        public TickMeter (OpenCVForUnity.CoreModule.TickMeter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
