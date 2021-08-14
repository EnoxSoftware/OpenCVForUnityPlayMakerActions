using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Tracker : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Tracker()
        {

        }

        public Tracker(OpenCVForUnity.VideoModule.Tracker nativeObj) : base(nativeObj)
        {

        }

    }
}
