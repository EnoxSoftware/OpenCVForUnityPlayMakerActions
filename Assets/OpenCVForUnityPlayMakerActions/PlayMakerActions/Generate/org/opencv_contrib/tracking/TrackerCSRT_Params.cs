using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerCSRT_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TrackerCSRT_Params()
        {

        }

        public TrackerCSRT_Params(OpenCVForUnity.TrackingModule.TrackerCSRT_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
