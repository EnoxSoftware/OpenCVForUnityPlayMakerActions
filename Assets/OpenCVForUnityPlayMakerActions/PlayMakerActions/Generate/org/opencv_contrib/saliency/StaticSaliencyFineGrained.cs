using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.SaliencyModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class StaticSaliencyFineGrained : OpenCVForUnityPlayMakerActions.StaticSaliency
    {

        public StaticSaliencyFineGrained ()
        {

        }

        public StaticSaliencyFineGrained (OpenCVForUnity.SaliencyModule.StaticSaliencyFineGrained nativeObj)
            : base (nativeObj)
        {

        }

    }
}
