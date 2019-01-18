using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class ThinPlateSplineShapeTransformer : OpenCVForUnityPlayMakerActions.ShapeTransformer
    {

        public ThinPlateSplineShapeTransformer ()
        {

        }

        public ThinPlateSplineShapeTransformer (OpenCVForUnity.ShapeModule.ThinPlateSplineShapeTransformer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
