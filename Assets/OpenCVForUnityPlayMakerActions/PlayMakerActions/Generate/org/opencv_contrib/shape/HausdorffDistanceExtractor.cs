using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class HausdorffDistanceExtractor : OpenCVForUnityPlayMakerActions.ShapeDistanceExtractor
    {

        public HausdorffDistanceExtractor ()
        {

        }

        public HausdorffDistanceExtractor (OpenCVForUnity.ShapeModule.HausdorffDistanceExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
