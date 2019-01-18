using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SelectiveSearchSegmentationStrategyMultiple : OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy
    {

        public SelectiveSearchSegmentationStrategyMultiple ()
        {

        }

        public SelectiveSearchSegmentationStrategyMultiple (OpenCVForUnity.XimgprocModule.SelectiveSearchSegmentationStrategyMultiple nativeObj)
            : base (nativeObj)
        {

        }

    }
}
