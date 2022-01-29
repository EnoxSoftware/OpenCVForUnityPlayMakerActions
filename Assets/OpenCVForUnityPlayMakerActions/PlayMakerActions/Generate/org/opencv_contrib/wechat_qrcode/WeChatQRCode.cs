using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Wechat_qrcodeModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class WeChatQRCode : OpenCVForUnityPlayMakerActions.DisposableOpenCVObject
    {

        public WeChatQRCode()
        {

        }

        public WeChatQRCode(OpenCVForUnity.Wechat_qrcodeModule.WeChatQRCode nativeObj) : base(nativeObj)
        {

        }

    }
}
