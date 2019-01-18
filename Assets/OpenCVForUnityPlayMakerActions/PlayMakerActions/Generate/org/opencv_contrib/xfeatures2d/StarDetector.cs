using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StarDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public StarDetector ()
        {

        }

        public StarDetector (OpenCVForUnity.Xfeatures2dModule.StarDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
