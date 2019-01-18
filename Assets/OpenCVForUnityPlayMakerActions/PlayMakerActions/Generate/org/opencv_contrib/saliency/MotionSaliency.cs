using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MotionSaliency : OpenCVForUnityPlayMakerActions.Saliency
    {

        public MotionSaliency ()
        {

        }

        public MotionSaliency (OpenCVForUnity.SaliencyModule.MotionSaliency nativeObj)
            : base (nativeObj)
        {

        }

    }
}
