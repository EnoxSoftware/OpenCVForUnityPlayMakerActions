using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerCSRT : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerCSRT()
        {

        }

        public TrackerCSRT(OpenCVForUnity.TrackingModule.TrackerCSRT nativeObj) : base(nativeObj)
        {

        }

    }
}
