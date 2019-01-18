using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class CLAHE : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public CLAHE ()
        {

        }

        public CLAHE (OpenCVForUnity.ImgprocModule.CLAHE nativeObj)
            : base (nativeObj)
        {

        }

    }
}
