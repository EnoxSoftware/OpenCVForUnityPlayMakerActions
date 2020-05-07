using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SIFT : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public SIFT()
        {

        }

        public SIFT(OpenCVForUnity.Xfeatures2dModule.SIFT nativeObj) : base(nativeObj)
        {

        }

    }
}
