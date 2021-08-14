using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip("public TrackerDaSiamRPN_Params()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params), "storeResult")]
    public class TrackerDaSiamRPN_Params_newTrackerDaSiamRPN_Params : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] TrackerDaSiamRPN_Params")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params();
            ((OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params)storeResult.Value).wrappedObject = new OpenCVForUnity.VideoModule.TrackerDaSiamRPN_Params();


        }

    }

}
