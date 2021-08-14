using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Phase_unwrappingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_phase_unwrapping")]
    [HutongGames.PlayMaker.Tooltip("public static HistogramPhaseUnwrapping create(HistogramPhaseUnwrapping_Params parameters)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params), "parameters")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping), "storeResult")]
    public class HistogramPhaseUnwrapping_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] HistogramPhaseUnwrapping_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params))]
        public HutongGames.PlayMaker.FsmObject parameters;

        [HutongGames.PlayMaker.ActionSection("[return] HistogramPhaseUnwrapping")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping))]
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

            if (!(parameters.Value is OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params))
            {
                LogError("parameters is not initialized. Add Action \"newHistogramPhaseUnwrapping_Params\".");
                return;
            }
            OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping_Params wrapped_parameters = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping_Params, OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping_Params>(parameters);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping();
            ((OpenCVForUnityPlayMakerActions.HistogramPhaseUnwrapping)storeResult.Value).wrappedObject = OpenCVForUnity.Phase_unwrappingModule.HistogramPhaseUnwrapping.create(wrapped_parameters);


        }

    }

}
