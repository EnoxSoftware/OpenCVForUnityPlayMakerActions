using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BackgroundSubtractorMOG2 : OpenCVForUnityPlayMakerActions.BackgroundSubtractor
    {

        public BackgroundSubtractorMOG2()
        {

        }

        public BackgroundSubtractorMOG2(OpenCVForUnity.VideoModule.BackgroundSubtractorMOG2 nativeObj) : base(nativeObj)
        {

        }

    }
}
