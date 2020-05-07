using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Params()
        {

        }

        public Params(OpenCVForUnity.Features2dModule.Params nativeObj) : base(nativeObj)
        {

        }

    }
}
