using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class GridBoard : OpenCVForUnityPlayMakerActions.Board
    {

        public GridBoard ()
        {

        }

        public GridBoard (OpenCVForUnity.GridBoard nativeObj)
            : base (nativeObj)
        {

        }

    }
}
