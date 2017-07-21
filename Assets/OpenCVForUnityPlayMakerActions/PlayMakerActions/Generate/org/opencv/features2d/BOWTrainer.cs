using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class BOWTrainer : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BOWTrainer ()
        {

        }

        public BOWTrainer (OpenCVForUnity.BOWTrainer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
