using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class EdgeDrawing_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public EdgeDrawing_Params()
        {

        }

        public EdgeDrawing_Params(OpenCVForUnity.XimgprocModule.EdgeDrawing_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
