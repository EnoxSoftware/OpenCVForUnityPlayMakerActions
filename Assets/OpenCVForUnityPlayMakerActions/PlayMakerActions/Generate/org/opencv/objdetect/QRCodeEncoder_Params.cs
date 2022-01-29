using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class QRCodeEncoder_Params : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public QRCodeEncoder_Params()
        {

        }

        public QRCodeEncoder_Params(OpenCVForUnity.ObjdetectModule.QRCodeEncoder_Params nativeObj) : base(nativeObj)
        {

        }

    }
}
