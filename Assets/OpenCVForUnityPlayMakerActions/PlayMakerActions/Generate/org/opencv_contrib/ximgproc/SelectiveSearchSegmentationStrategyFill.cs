using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SelectiveSearchSegmentationStrategyFill : OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy
    {

        public SelectiveSearchSegmentationStrategyFill ()
        {

        }

        public SelectiveSearchSegmentationStrategyFill (OpenCVForUnity.XimgprocModule.SelectiveSearchSegmentationStrategyFill nativeObj)
            : base (nativeObj)
        {

        }

    }
}
