using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FaceDetectorYN : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public FaceDetectorYN()
        {

        }

        public FaceDetectorYN(OpenCVForUnity.ObjdetectModule.FaceDetectorYN nativeObj) : base(nativeObj)
        {

        }

    }
}
