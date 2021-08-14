using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip("public static TrackerDaSiamRPN create(TrackerDaSiamRPN_Params parameters)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params), "parameters")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN), "storeResult")]
    public class TrackerDaSiamRPN_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] TrackerDaSiamRPN_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params))]
        public HutongGames.PlayMaker.FsmObject parameters;

        [HutongGames.PlayMaker.ActionSection("[return] TrackerDaSiamRPN")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            parameters = null;
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

            if (!(parameters.Value is OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params))
            {
                LogError("parameters is not initialized. Add Action \"newTrackerDaSiamRPN_Params\".");
                return;
            }
            OpenCVForUnity.VideoModule.TrackerDaSiamRPN_Params wrapped_parameters = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN_Params, OpenCVForUnity.VideoModule.TrackerDaSiamRPN_Params>(parameters);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN();
            ((OpenCVForUnityPlayMakerActions.TrackerDaSiamRPN)storeResult.Value).wrappedObject = OpenCVForUnity.VideoModule.TrackerDaSiamRPN.create(wrapped_parameters);


        }

    }

}
