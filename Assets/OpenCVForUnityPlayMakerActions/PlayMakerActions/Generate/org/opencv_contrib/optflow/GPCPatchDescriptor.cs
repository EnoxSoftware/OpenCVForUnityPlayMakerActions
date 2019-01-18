using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GPCPatchDescriptor : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public GPCPatchDescriptor ()
        {

        }

        public GPCPatchDescriptor (OpenCVForUnity.OptflowModule.GPCPatchDescriptor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
