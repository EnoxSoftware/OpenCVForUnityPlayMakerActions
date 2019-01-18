using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FacemarkTrain : OpenCVForUnityPlayMakerActions.Facemark
    {

        public FacemarkTrain ()
        {

        }

        public FacemarkTrain (OpenCVForUnity.FaceModule.FacemarkTrain nativeObj)
            : base (nativeObj)
        {

        }

    }
}
