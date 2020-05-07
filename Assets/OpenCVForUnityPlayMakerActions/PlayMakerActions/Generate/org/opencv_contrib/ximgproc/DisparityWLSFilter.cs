using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class DisparityWLSFilter : OpenCVForUnityPlayMakerActions.DisparityFilter
    {

        public DisparityWLSFilter()
        {

        }

        public DisparityWLSFilter(OpenCVForUnity.XimgprocModule.DisparityWLSFilter nativeObj) : base(nativeObj)
        {

        }

    }
}
