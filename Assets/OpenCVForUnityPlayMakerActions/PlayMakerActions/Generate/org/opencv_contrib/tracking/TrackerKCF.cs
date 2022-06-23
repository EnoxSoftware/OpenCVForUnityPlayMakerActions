using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerKCF : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerKCF()
        {

        }

        public TrackerKCF(OpenCVForUnity.TrackingModule.TrackerKCF nativeObj) : base(nativeObj)
        {

        }

    }
}
