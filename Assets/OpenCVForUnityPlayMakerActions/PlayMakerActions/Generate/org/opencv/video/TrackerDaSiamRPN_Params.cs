using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerDaSiamRPN_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TrackerDaSiamRPN_Params()
        {

        }

        public TrackerDaSiamRPN_Params(OpenCVForUnity.VideoModule.TrackerDaSiamRPN_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
