using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GPCDetails : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public GPCDetails ()
        {

        }

        public GPCDetails (OpenCVForUnity.OptflowModule.GPCDetails nativeObj)
            : base (nativeObj)
        {

        }

    }
}
