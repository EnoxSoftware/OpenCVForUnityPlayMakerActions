using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SparseOpticalFlow : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public SparseOpticalFlow()
        {

        }

        public SparseOpticalFlow(OpenCVForUnity.VideoModule.SparseOpticalFlow nativeObj) : base(nativeObj)
        {

        }

    }
}
