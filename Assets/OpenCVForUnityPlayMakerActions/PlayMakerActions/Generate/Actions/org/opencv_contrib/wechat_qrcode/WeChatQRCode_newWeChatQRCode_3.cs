using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Wechat_qrcodeModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_wechat_qrcode")]
    [HutongGames.PlayMaker.Tooltip("public WeChatQRCode(string detector_prototxt_path)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "detector_prototxt_path")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.WeChatQRCode), "storeResult")]
    public class WeChatQRCode_newWeChatQRCode_3 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString detector_prototxt_path;

        [HutongGames.PlayMaker.ActionSection("[return] WeChatQRCode")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.WeChatQRCode))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            detector_prototxt_path = null;
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
            ((OpenCVForUnityPlayMakerActions.WeChatQRCode)storeResult.Value).wrappedObject = new OpenCVForUnity.Wechat_qrcodeModule.WeChatQRCode(detector_prototxt_path.Value);


        }

    }

}
