using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerMedianFlow : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerMedianFlow()
        {

        }

        public TrackerMedianFlow(OpenCVForUnity.TrackingModule.TrackerMedianFlow nativeObj) : base(nativeObj)
        {

        }

    }
}
