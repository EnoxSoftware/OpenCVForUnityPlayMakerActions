using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MinMaxLocResult : OpenCVForUnityPlayMakerActions.OpenCVObject
    {

        public MinMaxLocResult ()
        {

        }

        public MinMaxLocResult (OpenCVForUnity.CoreModule.Core.MinMaxLocResult nativeObj)
            : base (nativeObj)
        {

        }

    }
}
