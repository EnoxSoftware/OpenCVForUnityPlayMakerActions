using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_tracking")]
    [HutongGames.PlayMaker.Tooltip("public static Tracker legacy_upgradeTrackingAPI(legacy_Tracker legacy_tracker)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.legacy_Tracker), "legacy_tracker")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Tracker), "storeResult")]
    public class Tracking_legacy_upgradeTrackingAPI : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] legacy_Tracker")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.legacy_Tracker))]
        public HutongGames.PlayMaker.FsmObject legacy_tracker;

        [HutongGames.PlayMaker.ActionSection("[return] Tracker")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Tracker))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            legacy_tracker = null;
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

            if (!(legacy_tracker.Value is OpenCVForUnityPlayMakerActions.legacy_Tracker))
            {
                LogError("legacy_tracker is not initialized. Add Action \"newlegacy_Tracker\".");
                return;
            }
            OpenCVForUnity.TrackingModule.legacy_Tracker wrapped_legacy_tracker = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.legacy_Tracker, OpenCVForUnity.TrackingModule.legacy_Tracker>(legacy_tracker);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Tracker)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Tracker();
            ((OpenCVForUnityPlayMakerActions.Tracker)storeResult.Value).wrappedObject = OpenCVForUnity.TrackingModule.Tracking.legacy_upgradeTrackingAPI(wrapped_legacy_tracker);


        }

    }

}
