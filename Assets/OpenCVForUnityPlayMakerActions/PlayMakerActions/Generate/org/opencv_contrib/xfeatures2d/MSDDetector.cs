using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MSDDetector : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public MSDDetector()
        {

        }

        public MSDDetector(OpenCVForUnity.Xfeatures2dModule.MSDDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
