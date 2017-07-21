using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class MinMaxLocResult : OpenCVForUnityPlayMakerActions.OpenCVObject
    {

        public MinMaxLocResult ()
        {

        }

        public MinMaxLocResult (OpenCVForUnity.Core.MinMaxLocResult nativeObj)
            : base (nativeObj)
        {

        }

    }
}
