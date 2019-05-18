using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerMIL : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerMIL()
        {

        }

        public TrackerMIL(OpenCVForUnity.TrackingModule.TrackerMIL nativeObj) : base(nativeObj)
        {

        }

    }
}
