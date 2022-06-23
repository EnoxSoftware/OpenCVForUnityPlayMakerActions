using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class AffineFeature : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public AffineFeature()
        {

        }

        public AffineFeature(OpenCVForUnity.Features2dModule.AffineFeature nativeObj) : base(nativeObj)
        {

        }

    }
}
