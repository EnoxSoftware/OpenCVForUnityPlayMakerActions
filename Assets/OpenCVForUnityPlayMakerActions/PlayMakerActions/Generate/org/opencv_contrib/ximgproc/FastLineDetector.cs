using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FastLineDetector : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public FastLineDetector()
        {

        }

        public FastLineDetector(OpenCVForUnity.XimgprocModule.FastLineDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
