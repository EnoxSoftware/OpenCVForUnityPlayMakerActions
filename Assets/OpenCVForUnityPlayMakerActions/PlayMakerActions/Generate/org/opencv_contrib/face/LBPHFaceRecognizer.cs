using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class LBPHFaceRecognizer : OpenCVForUnityPlayMakerActions.FaceRecognizer
    {

        public LBPHFaceRecognizer ()
        {

        }

        public LBPHFaceRecognizer (OpenCVForUnity.LBPHFaceRecognizer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
