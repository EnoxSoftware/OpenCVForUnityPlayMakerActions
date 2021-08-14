using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_tracking")]
    [HutongGames.PlayMaker.Tooltip("public static TrackerCSRT create(TrackerCSRT_Params parameters)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerCSRT_Params), "parameters")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerCSRT), "storeResult")]
    public class TrackerCSRT_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] TrackerCSRT_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerCSRT_Params))]
        public HutongGames.PlayMaker.FsmObject parameters;

        [HutongGames.PlayMaker.ActionSection("[return] TrackerCSRT")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerCSRT))]
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

            if (!(parameters.Value is OpenCVForUnityPlayMakerActions.TrackerCSRT_Params))
            {
                LogError("parameters is not initialized. Add Action \"newTrackerCSRT_Params\".");
                return;
            }
            OpenCVForUnity.TrackingModule.TrackerCSRT_Params wrapped_parameters = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TrackerCSRT_Params, OpenCVForUnity.TrackingModule.TrackerCSRT_Params>(parameters);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TrackerCSRT)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TrackerCSRT();
            ((OpenCVForUnityPlayMakerActions.TrackerCSRT)storeResult.Value).wrappedObject = OpenCVForUnity.TrackingModule.TrackerCSRT.create(wrapped_parameters);


        }

    }

}
