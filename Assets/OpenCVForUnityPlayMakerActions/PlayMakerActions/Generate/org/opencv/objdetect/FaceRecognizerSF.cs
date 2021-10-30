using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class FaceRecognizerSF : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public FaceRecognizerSF()
        {

        }

        public FaceRecognizerSF(OpenCVForUnity.ObjdetectModule.FaceRecognizerSF nativeObj) : base(nativeObj)
        {

        }

    }
}
