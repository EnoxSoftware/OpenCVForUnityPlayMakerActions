using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerMIL_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TrackerMIL_Params()
        {

        }

        public TrackerMIL_Params(OpenCVForUnity.VideoModule.TrackerMIL_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
