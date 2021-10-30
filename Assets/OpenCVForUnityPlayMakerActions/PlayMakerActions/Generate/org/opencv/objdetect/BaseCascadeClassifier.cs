using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BaseCascadeClassifier : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public BaseCascadeClassifier()
        {

        }

        public BaseCascadeClassifier(OpenCVForUnity.ObjdetectModule.BaseCascadeClassifier nativeObj) : base(nativeObj)
        {

        }

    }
}
