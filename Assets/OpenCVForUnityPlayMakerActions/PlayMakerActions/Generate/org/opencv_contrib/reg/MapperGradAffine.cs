using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.RegModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MapperGradAffine : OpenCVForUnityPlayMakerActions.Mapper
    {

        public MapperGradAffine ()
        {

        }

        public MapperGradAffine (OpenCVForUnity.RegModule.MapperGradAffine nativeObj)
            : base (nativeObj)
        {

        }

    }
}
