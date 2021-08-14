using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip("public static TrackerMIL create(TrackerMIL_Params parameters)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerMIL_Params), "parameters")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerMIL), "storeResult")]
    public class TrackerMIL_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] TrackerMIL_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerMIL_Params))]
        public HutongGames.PlayMaker.FsmObject parameters;

        [HutongGames.PlayMaker.ActionSection("[return] TrackerMIL")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerMIL))]
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

            if (!(parameters.Value is OpenCVForUnityPlayMakerActions.TrackerMIL_Params))
            {
                LogError("parameters is not initialized. Add Action \"newTrackerMIL_Params\".");
                return;
            }
            OpenCVForUnity.VideoModule.TrackerMIL_Params wrapped_parameters = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TrackerMIL_Params, OpenCVForUnity.VideoModule.TrackerMIL_Params>(parameters);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TrackerMIL)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TrackerMIL();
            ((OpenCVForUnityPlayMakerActions.TrackerMIL)storeResult.Value).wrappedObject = OpenCVForUnity.VideoModule.TrackerMIL.create(wrapped_parameters);


        }

    }

}
