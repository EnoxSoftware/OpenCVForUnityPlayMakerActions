using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class LearningBasedWB : OpenCVForUnityPlayMakerActions.WhiteBalancer
    {

        public LearningBasedWB ()
        {

        }

        public LearningBasedWB (OpenCVForUnity.LearningBasedWB nativeObj)
            : base (nativeObj)
        {

        }

    }
}
