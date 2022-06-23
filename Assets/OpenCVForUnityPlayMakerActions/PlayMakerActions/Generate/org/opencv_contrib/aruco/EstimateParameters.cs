using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class EstimateParameters : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public EstimateParameters()
        {

        }

        public EstimateParameters(OpenCVForUnity.ArucoModule.EstimateParameters nativeObj) : base(nativeObj)
        {

        }

    }
}
