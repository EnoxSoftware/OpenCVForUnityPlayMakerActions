using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Saliency : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public Saliency ()
        {

        }

        public Saliency (OpenCVForUnity.SaliencyModule.Saliency nativeObj)
            : base (nativeObj)
        {

        }

    }
}
