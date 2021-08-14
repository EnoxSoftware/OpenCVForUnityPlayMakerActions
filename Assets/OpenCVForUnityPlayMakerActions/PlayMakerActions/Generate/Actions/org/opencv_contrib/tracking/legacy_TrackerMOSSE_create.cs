using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_tracking")]
    [HutongGames.PlayMaker.Tooltip("public static legacy_TrackerMOSSE create()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.legacy_TrackerMOSSE), "storeResult")]
    public class legacy_TrackerMOSSE_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] legacy_TrackerMOSSE")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.legacy_TrackerMOSSE))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.legacy_TrackerMOSSE)) storeResult.Value = new OpenCVForUnityPlayMakerActions.legacy_TrackerMOSSE();
            ((OpenCVForUnityPlayMakerActions.legacy_TrackerMOSSE)storeResult.Value).wrappedObject = OpenCVForUnity.TrackingModule.legacy_TrackerMOSSE.create();


        }

    }

}
