using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class NormalBayesClassifier : OpenCVForUnityPlayMakerActions.StatModel
    {

        public NormalBayesClassifier ()
        {

        }

        public NormalBayesClassifier (OpenCVForUnity.NormalBayesClassifier nativeObj)
            : base (nativeObj)
        {

        }

    }
}
