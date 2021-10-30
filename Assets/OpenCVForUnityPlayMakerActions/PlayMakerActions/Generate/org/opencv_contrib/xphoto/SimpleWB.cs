using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XphotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class SimpleWB : OpenCVForUnityPlayMakerActions.WhiteBalancer
    {

        public SimpleWB()
        {

        }

        public SimpleWB(OpenCVForUnity.XphotoModule.SimpleWB nativeObj) : base(nativeObj)
        {

        }

    }
}
