using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StaticSaliency : OpenCVForUnityPlayMakerActions.Saliency
    {

        public StaticSaliency ()
        {

        }

        public StaticSaliency (OpenCVForUnity.SaliencyModule.StaticSaliency nativeObj)
            : base (nativeObj)
        {

        }

    }
}
