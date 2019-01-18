using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FaceRecognizer : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public FaceRecognizer ()
        {

        }

        public FaceRecognizer (OpenCVForUnity.FaceModule.FaceRecognizer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
