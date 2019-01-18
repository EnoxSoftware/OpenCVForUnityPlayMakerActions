using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GPCTrainingSamples : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public GPCTrainingSamples ()
        {

        }

        public GPCTrainingSamples (OpenCVForUnity.OptflowModule.GPCTrainingSamples nativeObj)
            : base (nativeObj)
        {

        }

    }
}
