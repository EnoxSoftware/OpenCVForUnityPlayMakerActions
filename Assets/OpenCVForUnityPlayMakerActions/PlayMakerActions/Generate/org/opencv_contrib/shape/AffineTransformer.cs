using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class AffineTransformer : OpenCVForUnityPlayMakerActions.ShapeTransformer
    {

        public AffineTransformer ()
        {

        }

        public AffineTransformer (OpenCVForUnity.ShapeModule.AffineTransformer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
