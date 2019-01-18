using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.RegModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Map : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Map ()
        {

        }

        public Map (OpenCVForUnity.RegModule.Map nativeObj)
            : base (nativeObj)
        {

        }

    }
}
