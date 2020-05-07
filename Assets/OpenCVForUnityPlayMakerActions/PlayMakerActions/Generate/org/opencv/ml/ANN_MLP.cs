using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ANN_MLP : OpenCVForUnityPlayMakerActions.StatModel
    {

        public ANN_MLP()
        {

        }

        public ANN_MLP(OpenCVForUnity.MlModule.ANN_MLP nativeObj) : base(nativeObj)
        {

        }

    }
}
