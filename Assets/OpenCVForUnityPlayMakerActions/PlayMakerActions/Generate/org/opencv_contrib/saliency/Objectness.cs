using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Objectness : OpenCVForUnityPlayMakerActions.Saliency
    {

        public Objectness ()
        {

        }

        public Objectness (OpenCVForUnity.SaliencyModule.Objectness nativeObj)
            : base (nativeObj)
        {

        }

    }
}
