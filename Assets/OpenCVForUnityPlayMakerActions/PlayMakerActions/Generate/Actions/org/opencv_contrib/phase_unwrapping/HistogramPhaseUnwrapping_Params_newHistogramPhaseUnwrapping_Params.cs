using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Phase_unwrappingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_phase_unwrapping")]
    [HutongGames.PlayMaker.Tooltip("public HistogramPhaseUnwrapping_Params()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params), "storeResult")]
    public class HistogramPhaseUnwrapping_Params_newHistogramPhaseUnwrapping_Params : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] HistogramPhaseUnwrapping_Params")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params();
            ((OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params)storeResult.Value).wrappedObject = new OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping_Params();


        }

    }

}
