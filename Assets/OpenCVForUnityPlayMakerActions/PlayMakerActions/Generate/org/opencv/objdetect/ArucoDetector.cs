using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ArucoDetector : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public ArucoDetector()
        {

        }

        public ArucoDetector(OpenCVForUnity.ObjdetectModule.ArucoDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
