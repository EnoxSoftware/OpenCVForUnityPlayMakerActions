using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.PhotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TonemapDurand : OpenCVForUnityPlayMakerActions.Tonemap
    {

        public TonemapDurand ()
        {

        }

        public TonemapDurand (OpenCVForUnity.PhotoModule.TonemapDurand nativeObj)
            : base (nativeObj)
        {

        }

    }
}
