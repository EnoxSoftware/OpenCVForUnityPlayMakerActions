using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Mat : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Mat ()
        {

        }

        public Mat (OpenCVForUnity.CoreModule.Mat nativeObj)
            : base (nativeObj)
        {

        }

    }
}
