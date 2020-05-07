using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class EigenFaceRecognizer : OpenCVForUnityPlayMakerActions.BasicFaceRecognizer
    {

        public EigenFaceRecognizer()
        {

        }

        public EigenFaceRecognizer(OpenCVForUnity.FaceModule.EigenFaceRecognizer nativeObj) : base(nativeObj)
        {

        }

    }
}
