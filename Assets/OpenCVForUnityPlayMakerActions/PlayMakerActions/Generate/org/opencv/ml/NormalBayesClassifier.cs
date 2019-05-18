using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class NormalBayesClassifier : OpenCVForUnityPlayMakerActions.StatModel
    {

        public NormalBayesClassifier()
        {

        }

        public NormalBayesClassifier(OpenCVForUnity.MlModule.NormalBayesClassifier nativeObj) : base(nativeObj)
        {

        }

    }
}
