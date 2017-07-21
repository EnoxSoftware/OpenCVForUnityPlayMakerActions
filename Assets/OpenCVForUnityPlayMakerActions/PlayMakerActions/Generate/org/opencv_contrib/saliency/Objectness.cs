using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Objectness : OpenCVForUnityPlayMakerActions.Saliency
    {

        public Objectness ()
        {

        }

        public Objectness (OpenCVForUnity.Objectness nativeObj)
            : base (nativeObj)
        {

        }

    }
}
