using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Dictionary : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Dictionary()
        {

        }

        public Dictionary(OpenCVForUnity.ObjdetectModule.Dictionary nativeObj) : base(nativeObj)
        {

        }

    }
}
