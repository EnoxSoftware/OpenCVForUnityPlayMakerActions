using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SIFT : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public SIFT()
        {

        }

        public SIFT(OpenCVForUnity.Features2dModule.SIFT nativeObj) : base(nativeObj)
        {

        }

    }
}
