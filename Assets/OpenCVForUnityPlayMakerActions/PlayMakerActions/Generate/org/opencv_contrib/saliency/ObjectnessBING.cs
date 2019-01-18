using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ObjectnessBING : OpenCVForUnityPlayMakerActions.Objectness
    {

        public ObjectnessBING ()
        {

        }

        public ObjectnessBING (OpenCVForUnity.SaliencyModule.ObjectnessBING nativeObj)
            : base (nativeObj)
        {

        }

    }
}
