using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoioModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class VideoCapture : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public VideoCapture ()
        {

        }

        public VideoCapture (OpenCVForUnity.VideoioModule.VideoCapture nativeObj)
            : base (nativeObj)
        {

        }

    }
}
