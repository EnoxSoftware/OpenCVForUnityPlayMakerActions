using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class StaticSaliency : OpenCVForUnityPlayMakerActions.Saliency
    {

        public StaticSaliency ()
        {

        }

        public StaticSaliency (OpenCVForUnity.StaticSaliency nativeObj)
            : base (nativeObj)
        {

        }

    }
}
