using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class LBPHFaceRecognizer : OpenCVForUnityPlayMakerActions.FaceRecognizer
    {

        public LBPHFaceRecognizer()
        {

        }

        public LBPHFaceRecognizer(OpenCVForUnity.FaceModule.LBPHFaceRecognizer nativeObj) : base(nativeObj)
        {

        }

    }
}
