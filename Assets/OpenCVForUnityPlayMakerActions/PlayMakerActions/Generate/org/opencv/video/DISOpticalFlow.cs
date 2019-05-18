using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DISOpticalFlow : OpenCVForUnityPlayMakerActions.DenseOpticalFlow
    {

        public DISOpticalFlow()
        {

        }

        public DISOpticalFlow(OpenCVForUnity.VideoModule.DISOpticalFlow nativeObj) : base(nativeObj)
        {

        }

    }
}
