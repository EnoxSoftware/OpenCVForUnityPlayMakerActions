#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Importer : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public Importer ()
        {

        }

        public Importer (OpenCVForUnity.Importer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
