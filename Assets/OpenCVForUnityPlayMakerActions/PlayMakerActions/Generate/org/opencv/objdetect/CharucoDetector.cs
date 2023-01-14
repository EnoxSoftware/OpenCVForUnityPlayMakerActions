using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CharucoDetector : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public CharucoDetector()
        {

        }

        public CharucoDetector(OpenCVForUnity.ObjdetectModule.CharucoDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
