using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractor : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public BackgroundSubtractor()
        {

        }

        public BackgroundSubtractor(OpenCVForUnity.VideoModule.BackgroundSubtractor nativeObj) : base(nativeObj)
        {

        }

    }
}
