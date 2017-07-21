using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    public class VariationalRefinement : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public VariationalRefinement ()
        {

        }

        public VariationalRefinement (OpenCVForUnity.VariationalRefinement nativeObj)
            : base (nativeObj)
        {

        }

    }
}
