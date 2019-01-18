using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.RegModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MapTypeCaster : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public MapTypeCaster ()
        {

        }

        public MapTypeCaster (OpenCVForUnity.RegModule.MapTypeCaster nativeObj)
            : base (nativeObj)
        {

        }

    }
}
