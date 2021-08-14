using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_tracking")]
    [HutongGames.PlayMaker.Tooltip("public TrackerCSRT_Params()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TrackerCSRT_Params), "storeResult")]
    public class TrackerCSRT_Params_newTrackerCSRT_Params : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] TrackerCSRT_Params")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TrackerCSRT_Params))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TrackerCSRT_Params)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TrackerCSRT_Params();
            ((OpenCVForUnityPlayMakerActions.TrackerCSRT_Params)storeResult.Value).wrappedObject = new OpenCVForUnity.TrackingModule.TrackerCSRT_Params();


        }

    }

}
