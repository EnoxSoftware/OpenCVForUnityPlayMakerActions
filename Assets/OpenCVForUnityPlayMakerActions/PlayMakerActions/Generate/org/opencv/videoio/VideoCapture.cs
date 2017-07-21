using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class VideoCapture : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public VideoCapture ()
        {

        }

        public VideoCapture (OpenCVForUnity.VideoCapture nativeObj)
            : base (nativeObj)
        {

        }

    }
}
