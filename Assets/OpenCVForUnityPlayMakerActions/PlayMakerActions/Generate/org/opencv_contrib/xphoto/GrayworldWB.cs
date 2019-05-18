using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XphotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class GrayworldWB : OpenCVForUnityPlayMakerActions.WhiteBalancer
    {

        public GrayworldWB()
        {

        }

        public GrayworldWB(OpenCVForUnity.XphotoModule.GrayworldWB nativeObj) : base(nativeObj)
        {

        }

    }
}
