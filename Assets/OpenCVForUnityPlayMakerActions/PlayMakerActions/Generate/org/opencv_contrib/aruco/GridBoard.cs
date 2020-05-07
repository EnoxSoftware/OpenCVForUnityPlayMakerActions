using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GridBoard : OpenCVForUnityPlayMakerActions.Board
    {

        public GridBoard()
        {

        }

        public GridBoard(OpenCVForUnity.ArucoModule.GridBoard nativeObj) : base(nativeObj)
        {

        }

    }
}
