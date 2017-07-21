using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class LogisticRegression : OpenCVForUnityPlayMakerActions.StatModel
    {

        public LogisticRegression ()
        {

        }

        public LogisticRegression (OpenCVForUnity.LogisticRegression nativeObj)
            : base (nativeObj)
        {

        }

    }
}
