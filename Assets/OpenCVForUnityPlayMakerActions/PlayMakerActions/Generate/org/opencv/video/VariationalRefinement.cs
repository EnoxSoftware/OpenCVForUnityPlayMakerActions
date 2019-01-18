using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class VariationalRefinement : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public VariationalRefinement ()
        {

        }

        public VariationalRefinement (OpenCVForUnity.VideoModule.VariationalRefinement nativeObj)
            : base (nativeObj)
        {

        }

    }
}
