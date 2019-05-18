using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DetectorParameters : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public DetectorParameters()
        {

        }

        public DetectorParameters(OpenCVForUnity.ArucoModule.DetectorParameters nativeObj) : base(nativeObj)
        {

        }

    }
}
