using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class HausdorffDistanceExtractor : OpenCVForUnityPlayMakerActions.ShapeDistanceExtractor
    {

        public HausdorffDistanceExtractor ()
        {

        }

        public HausdorffDistanceExtractor (OpenCVForUnity.HausdorffDistanceExtractor nativeObj)
            : base (nativeObj)
        {

        }

    }
}
