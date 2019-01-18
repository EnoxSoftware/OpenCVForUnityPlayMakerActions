using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CascadeClassifier : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public CascadeClassifier ()
        {

        }

        public CascadeClassifier (OpenCVForUnity.ObjdetectModule.CascadeClassifier nativeObj)
            : base (nativeObj)
        {

        }

    }
}
