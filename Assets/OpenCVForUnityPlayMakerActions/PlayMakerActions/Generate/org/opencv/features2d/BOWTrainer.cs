using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BOWTrainer : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BOWTrainer()
        {

        }

        public BOWTrainer(OpenCVForUnity.Features2dModule.BOWTrainer nativeObj) : base(nativeObj)
        {

        }

    }
}
