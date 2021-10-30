using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FacemarkLBF : OpenCVForUnityPlayMakerActions.FacemarkTrain
    {

        public FacemarkLBF()
        {

        }

        public FacemarkLBF(OpenCVForUnity.FaceModule.FacemarkLBF nativeObj) : base(nativeObj)
        {

        }

    }
}
