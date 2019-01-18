using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class LogisticRegression : OpenCVForUnityPlayMakerActions.StatModel
    {

        public LogisticRegression ()
        {

        }

        public LogisticRegression (OpenCVForUnity.MlModule.LogisticRegression nativeObj)
            : base (nativeObj)
        {

        }

    }
}
