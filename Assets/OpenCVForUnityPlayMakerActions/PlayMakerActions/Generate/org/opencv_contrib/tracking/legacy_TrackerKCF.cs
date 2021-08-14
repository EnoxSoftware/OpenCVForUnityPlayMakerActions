using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class legacy_TrackerKCF : OpenCVForUnityPlayMakerActions.legacy_Tracker
    {

        public legacy_TrackerKCF()
        {

        }

        public legacy_TrackerKCF(OpenCVForUnity.TrackingModule.legacy_TrackerKCF nativeObj) : base(nativeObj)
        {

        }

    }
}
