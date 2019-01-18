using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Board : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Board ()
        {

        }

        public Board (OpenCVForUnity.ArucoModule.Board nativeObj)
            : base (nativeObj)
        {

        }

    }
}
