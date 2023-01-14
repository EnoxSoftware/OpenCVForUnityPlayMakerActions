using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CharucoParameters : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public CharucoParameters()
        {

        }

        public CharucoParameters(OpenCVForUnity.ObjdetectModule.CharucoParameters nativeObj) : base(nativeObj)
        {

        }

    }
}
