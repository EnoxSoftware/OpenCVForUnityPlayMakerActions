using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FisherFaceRecognizer : OpenCVForUnityPlayMakerActions.BasicFaceRecognizer
    {

        public FisherFaceRecognizer()
        {

        }

        public FisherFaceRecognizer(OpenCVForUnity.FaceModule.FisherFaceRecognizer nativeObj) : base(nativeObj)
        {

        }

    }
}
