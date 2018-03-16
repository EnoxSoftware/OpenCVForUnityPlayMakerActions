#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class DictValue : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public DictValue ()
        {

        }

        public DictValue (OpenCVForUnity.DictValue nativeObj)
            : base (nativeObj)
        {

        }

    }
}
#endif
