using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorKNN : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorKNN()
        {

        }

        public BackgroundSubtractorKNN(OpenCVForUnity.VideoModule.BackgroundSubtractorKNN nativeObj) : base(nativeObj)
        {

        }

    }
}
