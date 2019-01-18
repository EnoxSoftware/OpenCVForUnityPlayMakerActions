using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ShapeContextDistanceExtractor : OpenCVForUnityPlayMakerActions.ShapeDistanceExtractor
    {

        public ShapeContextDistanceExtractor ()
        {

        }

        public ShapeContextDistanceExtractor (OpenCVForUnity.ShapeModule.ShapeContextDistanceExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
