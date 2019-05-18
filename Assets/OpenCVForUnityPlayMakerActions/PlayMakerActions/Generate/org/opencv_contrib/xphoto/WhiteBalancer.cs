using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XphotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class WhiteBalancer : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public WhiteBalancer()
        {

        }

        public WhiteBalancer(OpenCVForUnity.XphotoModule.WhiteBalancer nativeObj) : base(nativeObj)
        {

        }

    }
}
