using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoioModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class VideoWriter : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public VideoWriter()
        {

        }

        public VideoWriter(OpenCVForUnity.VideoioModule.VideoWriter nativeObj) : base(nativeObj)
        {

        }

    }
}
