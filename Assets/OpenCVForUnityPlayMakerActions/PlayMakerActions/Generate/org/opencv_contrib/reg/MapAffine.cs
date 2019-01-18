using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.RegModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MapAffine : OpenCVForUnityPlayMakerActions.Map
    {

        public MapAffine ()
        {

        }

        public MapAffine (OpenCVForUnity.RegModule.MapAffine nativeObj)
            : base (nativeObj)
        {

        }

    }
}
