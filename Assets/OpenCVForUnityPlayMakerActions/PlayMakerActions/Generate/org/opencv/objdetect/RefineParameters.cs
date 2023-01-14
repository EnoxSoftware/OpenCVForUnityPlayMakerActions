using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class RefineParameters : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public RefineParameters()
        {

        }

        public RefineParameters(OpenCVForUnity.ObjdetectModule.RefineParameters nativeObj) : base(nativeObj)
        {

        }

    }
}
