using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class VideoWriter : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public VideoWriter ()
        {

        }

        public VideoWriter (OpenCVForUnity.VideoWriter nativeObj)
            : base (nativeObj)
        {

        }

    }
}
