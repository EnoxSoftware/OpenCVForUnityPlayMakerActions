using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SuperpixelSEEDS : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public SuperpixelSEEDS ()
        {

        }

        public SuperpixelSEEDS (OpenCVForUnity.XimgprocModule.SuperpixelSEEDS nativeObj)
            : base (nativeObj)
        {

        }

    }
}
