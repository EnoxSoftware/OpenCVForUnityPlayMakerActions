using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{

    public class DisposableOpenCVObject : OpenCVObject
    {

        public DisposableOpenCVObject()
        {

        }

        public DisposableOpenCVObject(OpenCVForUnity.DisposableOpenCVObject nativeObj)
            : base(nativeObj)
        {

        }
    }
}