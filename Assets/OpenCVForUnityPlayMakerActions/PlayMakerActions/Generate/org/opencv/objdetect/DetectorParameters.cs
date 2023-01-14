using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DetectorParameters : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public DetectorParameters()
        {

        }

        public DetectorParameters(OpenCVForUnity.ObjdetectModule.DetectorParameters nativeObj) : base(nativeObj)
        {

        }

    }
}
