using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.RegModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Mapper : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Mapper ()
        {

        }

        public Mapper (OpenCVForUnity.RegModule.Mapper nativeObj)
            : base (nativeObj)
        {

        }

    }
}
