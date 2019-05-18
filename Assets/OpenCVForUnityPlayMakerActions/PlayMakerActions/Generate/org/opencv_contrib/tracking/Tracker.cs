using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Tracker : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public Tracker()
        {

        }

        public Tracker(OpenCVForUnity.TrackingModule.Tracker nativeObj) : base(nativeObj)
        {

        }

    }
}
