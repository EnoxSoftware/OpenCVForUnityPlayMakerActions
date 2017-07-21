using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class HOGDescriptor : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public HOGDescriptor ()
        {

        }

        public HOGDescriptor (OpenCVForUnity.HOGDescriptor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
