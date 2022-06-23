using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ParamGrid : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public ParamGrid()
        {

        }

        public ParamGrid(OpenCVForUnity.MlModule.ParamGrid nativeObj) : base(nativeObj)
        {

        }

    }
}
