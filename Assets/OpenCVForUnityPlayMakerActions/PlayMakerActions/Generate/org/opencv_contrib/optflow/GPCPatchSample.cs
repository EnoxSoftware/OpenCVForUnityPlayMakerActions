using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GPCPatchSample : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public GPCPatchSample ()
        {

        }

        public GPCPatchSample (OpenCVForUnity.OptflowModule.GPCPatchSample nativeObj)
            : base (nativeObj)
        {

        }

    }
}
