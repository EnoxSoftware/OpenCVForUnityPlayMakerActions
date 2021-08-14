using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrackerKCF_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TrackerKCF_Params()
        {

        }

        public TrackerKCF_Params(OpenCVForUnity.TrackingModule.TrackerKCF_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
