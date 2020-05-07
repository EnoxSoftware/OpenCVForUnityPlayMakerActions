using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CharucoBoard : OpenCVForUnityPlayMakerActions.Board
    {

        public CharucoBoard()
        {

        }

        public CharucoBoard(OpenCVForUnity.ArucoModule.CharucoBoard nativeObj) : base(nativeObj)
        {

        }

    }
}
