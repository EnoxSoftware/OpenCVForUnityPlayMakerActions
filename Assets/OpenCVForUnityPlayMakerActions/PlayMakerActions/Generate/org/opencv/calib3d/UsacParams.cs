using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Calib3dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class UsacParams : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public UsacParams()
        {

        }

        public UsacParams(OpenCVForUnity.Calib3dModule.UsacParams nativeObj) : base(nativeObj)
        {

        }

    }
}
