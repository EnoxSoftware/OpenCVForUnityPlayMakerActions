using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Dictionary : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Dictionary ()
        {

        }

        public Dictionary (OpenCVForUnity.ArucoModule.Dictionary nativeObj)
            : base (nativeObj)
        {

        }

    }
}
