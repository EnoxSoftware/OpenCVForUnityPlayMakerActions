using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerNano_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TrackerNano_Params()
        {

        }

        public TrackerNano_Params(OpenCVForUnity.VideoModule.TrackerNano_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
