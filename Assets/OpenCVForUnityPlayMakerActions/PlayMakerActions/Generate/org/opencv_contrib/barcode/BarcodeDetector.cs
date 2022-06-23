using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BarcodeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class BarcodeDetector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public BarcodeDetector()
        {

        }

        public BarcodeDetector(OpenCVForUnity.BarcodeModule.BarcodeDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
