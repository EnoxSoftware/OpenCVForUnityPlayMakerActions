using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BRISK : OpenCVForUnityPlayMakerActions.Feature2D
    {

        public BRISK ()
        {

        }

        public BRISK (OpenCVForUnity.Features2dModule.BRISK nativeObj)
            : base (nativeObj)
        {

        }

    }
}
