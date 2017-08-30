using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class EigenFaceRecognizer : OpenCVForUnityPlayMakerActions.BasicFaceRecognizer
    {

        public EigenFaceRecognizer ()
        {

        }

        public EigenFaceRecognizer (OpenCVForUnity.EigenFaceRecognizer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
