using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TrainData : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public TrainData()
        {

        }

        public TrainData(OpenCVForUnity.MlModule.TrainData nativeObj) : base(nativeObj)
        {

        }

    }
}
