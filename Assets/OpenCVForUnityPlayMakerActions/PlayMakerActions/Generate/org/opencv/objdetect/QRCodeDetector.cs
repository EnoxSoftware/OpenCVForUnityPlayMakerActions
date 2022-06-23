using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class QRCodeDetector : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public QRCodeDetector()
        {

        }

        public QRCodeDetector(OpenCVForUnity.ObjdetectModule.QRCodeDetector nativeObj) : base(nativeObj)
        {

        }

    }
}
