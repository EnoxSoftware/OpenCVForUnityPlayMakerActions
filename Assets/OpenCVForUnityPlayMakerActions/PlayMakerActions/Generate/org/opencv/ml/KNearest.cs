using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.MlModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class KNearest : OpenCVForUnityPlayMakerActions.StatModel
    {

        public KNearest ()
        {

        }

        public KNearest (OpenCVForUnity.MlModule.KNearest nativeObj)
            : base (nativeObj)
        {

        }

    }
}
