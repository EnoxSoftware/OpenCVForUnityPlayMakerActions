using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class PCAPrior : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public PCAPrior ()
        {

        }

        public PCAPrior (OpenCVForUnity.OptflowModule.PCAPrior nativeObj)
            : base (nativeObj)
        {

        }

    }
}
