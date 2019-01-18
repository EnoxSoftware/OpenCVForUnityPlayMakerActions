using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class HOGDescriptor : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public HOGDescriptor ()
        {

        }

        public HOGDescriptor (OpenCVForUnity.ObjdetectModule.HOGDescriptor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
