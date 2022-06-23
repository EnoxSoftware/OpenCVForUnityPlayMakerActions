using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerMIL : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerMIL()
        {

        }

        public TrackerMIL(OpenCVForUnity.VideoModule.TrackerMIL nativeObj) : base(nativeObj)
        {

        }

    }
}
