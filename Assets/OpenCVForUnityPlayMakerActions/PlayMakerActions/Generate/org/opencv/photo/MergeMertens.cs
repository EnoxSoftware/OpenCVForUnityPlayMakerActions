using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.PhotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class MergeMertens : OpenCVForUnityPlayMakerActions.MergeExposures
    {

        public MergeMertens ()
        {

        }

        public MergeMertens (OpenCVForUnity.PhotoModule.MergeMertens nativeObj)
            : base (nativeObj)
        {

        }

    }
}
