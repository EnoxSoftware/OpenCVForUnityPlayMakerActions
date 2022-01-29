using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class QRCodeEncoder : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public QRCodeEncoder()
        {

        }

        public QRCodeEncoder(OpenCVForUnity.ObjdetectModule.QRCodeEncoder nativeObj) : base(nativeObj)
        {

        }

    }
}
