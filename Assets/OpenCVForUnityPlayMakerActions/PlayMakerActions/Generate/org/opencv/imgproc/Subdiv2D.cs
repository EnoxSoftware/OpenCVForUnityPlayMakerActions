using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class Subdiv2D : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public Subdiv2D()
        {

        }

        public Subdiv2D(OpenCVForUnity.ImgprocModule.Subdiv2D nativeObj) : base(nativeObj)
        {

        }

    }
}
