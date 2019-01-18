using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BOWKMeansTrainer : OpenCVForUnityPlayMakerActions.BOWTrainer
    {

        public BOWKMeansTrainer ()
        {

        }

        public BOWKMeansTrainer (OpenCVForUnity.Features2dModule.BOWKMeansTrainer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
