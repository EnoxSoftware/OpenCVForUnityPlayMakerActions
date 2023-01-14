using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Board : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Board()
        {

        }

        public Board(OpenCVForUnity.ObjdetectModule.Board nativeObj) : base(nativeObj)
        {

        }

    }
}
