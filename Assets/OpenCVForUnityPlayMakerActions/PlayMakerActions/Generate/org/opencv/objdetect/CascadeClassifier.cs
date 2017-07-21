using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class CascadeClassifier : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public CascadeClassifier ()
        {

        }

        public CascadeClassifier (OpenCVForUnity.CascadeClassifier nativeObj)
            : base (nativeObj)
        {

        }

    }
}
