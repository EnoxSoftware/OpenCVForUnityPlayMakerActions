using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.PhotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class TonemapReinhard : OpenCVForUnityPlayMakerActions.Tonemap
    {

        public TonemapReinhard()
        {

        }

        public TonemapReinhard(OpenCVForUnity.PhotoModule.TonemapReinhard nativeObj) : base(nativeObj)
        {

        }

    }
}
