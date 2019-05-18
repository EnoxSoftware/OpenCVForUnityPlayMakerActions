using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BasicFaceRecognizer : OpenCVForUnityPlayMakerActions.FaceRecognizer
    {

        public BasicFaceRecognizer()
        {

        }

        public BasicFaceRecognizer(OpenCVForUnity.FaceModule.BasicFaceRecognizer nativeObj) : base(nativeObj)
        {

        }

    }
}
