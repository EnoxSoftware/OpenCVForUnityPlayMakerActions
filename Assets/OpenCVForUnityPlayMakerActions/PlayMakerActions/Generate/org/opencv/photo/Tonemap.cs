using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.PhotoModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Tonemap : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public Tonemap()
        {

        }

        public Tonemap(OpenCVForUnity.PhotoModule.Tonemap nativeObj) : base(nativeObj)
        {

        }

    }
}
