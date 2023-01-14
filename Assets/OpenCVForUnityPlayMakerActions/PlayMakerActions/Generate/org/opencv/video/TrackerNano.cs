using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerNano : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerNano()
        {

        }

        public TrackerNano(OpenCVForUnity.VideoModule.TrackerNano nativeObj) : base(nativeObj)
        {

        }

    }
}
