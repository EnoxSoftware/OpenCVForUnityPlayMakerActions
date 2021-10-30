using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerDaSiamRPN : OpenCVForUnityPlayMakerActions.Tracker
    {

        public TrackerDaSiamRPN()
        {

        }

        public TrackerDaSiamRPN(OpenCVForUnity.VideoModule.TrackerDaSiamRPN nativeObj) : base(nativeObj)
        {

        }

    }
}
