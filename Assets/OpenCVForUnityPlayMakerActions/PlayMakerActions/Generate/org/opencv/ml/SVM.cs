using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SVM : OpenCVForUnityPlayMakerActions.StatModel
    {

        public SVM()
        {

        }

        public SVM(OpenCVForUnity.MlModule.SVM nativeObj) : base(nativeObj)
        {

        }

    }
}
