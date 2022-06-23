using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class AffineFeature2D : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public AffineFeature2D()
        {

        }

        public AffineFeature2D(OpenCVForUnity.Xfeatures2dModule.AffineFeature2D nativeObj) : base(nativeObj)
        {

        }

    }
}
