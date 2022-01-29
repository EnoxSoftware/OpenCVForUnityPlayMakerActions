using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Wechat_qrcodeModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_wechat_qrcode")]
    [HutongGames.PlayMaker.Tooltip("public WeChatQRCode()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.WeChatQRCode), "storeResult")]
    public class WeChatQRCode_newWeChatQRCode_4 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] WeChatQRCode")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.WeChatQRCode))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            storeResult = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoProcess();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoProcess();
        }

        void DoProcess()
        {

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.WeChatQRCode)) storeResult.Value = new OpenCVForUnityPlayMakerActions.WeChatQRCode();
            ((OpenCVForUnityPlayMakerActions.WeChatQRCode)storeResult.Value).wrappedObject = new OpenCVForUnity.Wechat_qrcodeModule.WeChatQRCode();


        }

    }

}
