using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SparsePyrLKOpticalFlow : OpenCVForUnityPlayMakerActions.SparseOpticalFlow
    {

        public SparsePyrLKOpticalFlow()
        {

        }

        public SparsePyrLKOpticalFlow(OpenCVForUnity.VideoModule.SparsePyrLKOpticalFlow nativeObj) : base(nativeObj)
        {

        }

    }
}
