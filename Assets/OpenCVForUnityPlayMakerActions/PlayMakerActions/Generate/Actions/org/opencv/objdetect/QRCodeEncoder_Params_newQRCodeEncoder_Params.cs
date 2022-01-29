using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_objdetect")]
    [HutongGames.PlayMaker.Tooltip("public QRCodeEncoder_Params()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.QRCodeEncoder_Params), "storeResult")]
    public class QRCodeEncoder_Params_newQRCodeEncoder_Params : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] QRCodeEncoder_Params")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.QRCodeEncoder_Params))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.QRCodeEncoder_Params)) storeResult.Value = new OpenCVForUnityPlayMakerActions.QRCodeEncoder_Params();
            ((OpenCVForUnityPlayMakerActions.QRCodeEncoder_Params)storeResult.Value).wrappedObject = new OpenCVForUnity.ObjdetectModule.QRCodeEncoder_Params();


        }

    }

}
