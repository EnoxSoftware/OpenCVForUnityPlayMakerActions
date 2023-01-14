using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GridBoard : OpenCVForUnityPlayMakerActions.Board
    {

        public GridBoard()
        {

        }

        public GridBoard(OpenCVForUnity.ObjdetectModule.GridBoard nativeObj) : base(nativeObj)
        {

        }

    }
}
