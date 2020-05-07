#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SegmentationModel : OpenCVForUnityPlayMakerActions.Model
    {

        public SegmentationModel()
        {

        }

        public SegmentationModel(OpenCVForUnity.DnnModule.SegmentationModel nativeObj) : base(nativeObj)
        {

        }

    }
}
#endif
