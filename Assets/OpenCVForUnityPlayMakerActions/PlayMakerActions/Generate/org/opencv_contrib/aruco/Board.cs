using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class Board : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Board ()
        {

        }

        public Board (OpenCVForUnity.Board nativeObj)
            : base (nativeObj)
        {

        }

    }
}
