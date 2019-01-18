using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerMOSSE : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerMOSSE ()
        {

        }

        public TrackerMOSSE (OpenCVForUnity.TrackingModule.TrackerMOSSE nativeObj)
            : base (nativeObj)
        {

        }

    }
}
