using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XphotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class LearningBasedWB : OpenCVForUnityPlayMakerActions.WhiteBalancer
    {

        public LearningBasedWB()
        {

        }

        public LearningBasedWB(OpenCVForUnity.XphotoModule.LearningBasedWB nativeObj) : base(nativeObj)
        {

        }

    }
}
