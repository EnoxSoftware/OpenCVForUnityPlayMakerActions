using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GeneralizedHoughBallard : OpenCVForUnityPlayMakerActions.GeneralizedHough
    {

        public GeneralizedHoughBallard()
        {

        }

        public GeneralizedHoughBallard(OpenCVForUnity.ImgprocModule.GeneralizedHoughBallard nativeObj) : base(nativeObj)
        {

        }

    }
}
