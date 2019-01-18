using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerTLD : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerTLD ()
        {

        }

        public TrackerTLD (OpenCVForUnity.TrackingModule.TrackerTLD nativeObj)
            : base (nativeObj)
        {

        }

    }
}
