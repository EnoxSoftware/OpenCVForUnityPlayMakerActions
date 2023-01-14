using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CharucoBoard : OpenCVForUnityPlayMakerActions.Board
    {

        public CharucoBoard()
        {

        }

        public CharucoBoard(OpenCVForUnity.ObjdetectModule.CharucoBoard nativeObj) : base(nativeObj)
        {

        }

    }
}
