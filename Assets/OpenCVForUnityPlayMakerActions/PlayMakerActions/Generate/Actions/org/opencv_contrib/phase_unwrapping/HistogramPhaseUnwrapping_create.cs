using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Phase_unwrappingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_phase_unwrapping")]
    [HutongGames.PlayMaker.Tooltip("public static HistogramPhaseUnwrapping create()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping), "storeResult")]
    public class HistogramPhaseUnwrapping_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] HistogramPhaseUnwrapping")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping();
            ((OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping)storeResult.Value).wrappedObject = OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping.create();


        }

    }

}
