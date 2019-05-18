using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MultiTracker : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public MultiTracker()
        {

        }

        public MultiTracker(OpenCVForUnity.TrackingModule.MultiTracker nativeObj) : base(nativeObj)
        {

        }

    }
}
