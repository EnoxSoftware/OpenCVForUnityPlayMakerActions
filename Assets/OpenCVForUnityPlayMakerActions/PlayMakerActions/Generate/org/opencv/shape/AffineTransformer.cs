using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class AffineTransformer : OpenCVForUnityPlayMakerActions.ShapeTransformer
    {

        public AffineTransformer ()
        {

        }

        public AffineTransformer (OpenCVForUnity.AffineTransformer nativeObj)
            : base (nativeObj)
        {

        }

    }
}
