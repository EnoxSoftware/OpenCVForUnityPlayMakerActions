using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_bgsegm")]
    [HutongGames.PlayMaker.Tooltip("public static BackgroundSubtractorGSOC createBackgroundSubtractorGSOC(int mc)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "mc")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.BackgroundSubtractorGSOC), "storeResult")]
    public class Bgsegm_createBackgroundSubtractorGSOC_10 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt mc;

        [HutongGames.PlayMaker.ActionSection("[return] BackgroundSubtractorGSOC")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.BackgroundSubtractorGSOC))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            mc = 0;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.BackgroundSubtractorGSOC)) storeResult.Value = new OpenCVForUnityPlayMakerActions.BackgroundSubtractorGSOC();
            ((OpenCVForUnityPlayMakerActions.BackgroundSubtractorGSOC)storeResult.Value).wrappedObject = OpenCVForUnity.BgsegmModule.Bgsegm.createBackgroundSubtractorGSOC(mc.Value);


        }

    }

}
