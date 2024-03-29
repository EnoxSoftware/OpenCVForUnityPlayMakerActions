using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BioinspiredModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_bioinspired")]
    [HutongGames.PlayMaker.Tooltip("public void setupOPLandIPLParvoChannel(bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Retina), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "colorMode")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "normaliseOutput")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "photoreceptorsLocalAdaptationSensitivity")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "photoreceptorsTemporalConstant")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "photoreceptorsSpatialConstant")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "horizontalCellsGain")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "HcellsTemporalConstant")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "HcellsSpatialConstant")]
    public class Retina_setupOPLandIPLParvoChannel_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] Retina")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Retina))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool colorMode;

        [HutongGames.PlayMaker.ActionSection("[arg2] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool normaliseOutput;

        [HutongGames.PlayMaker.ActionSection("[arg3] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat photoreceptorsLocalAdaptationSensitivity;

        [HutongGames.PlayMaker.ActionSection("[arg4] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat photoreceptorsTemporalConstant;

        [HutongGames.PlayMaker.ActionSection("[arg5] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat photoreceptorsSpatialConstant;

        [HutongGames.PlayMaker.ActionSection("[arg6] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat horizontalCellsGain;

        [HutongGames.PlayMaker.ActionSection("[arg7] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat HcellsTemporalConstant;

        [HutongGames.PlayMaker.ActionSection("[arg8] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat HcellsSpatialConstant;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            colorMode = false;
            normaliseOutput = false;
            photoreceptorsLocalAdaptationSensitivity = 0.0f;
            photoreceptorsTemporalConstant = 0.0f;
            photoreceptorsSpatialConstant = 0.0f;
            horizontalCellsGain = 0.0f;
            HcellsTemporalConstant = 0.0f;
            HcellsSpatialConstant = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Retina))
            {
                LogError("owner is not initialized. Add Action \"newRetina\".");
                return;
            }
            OpenCVForUnity.BioinspiredModule.Retina wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Retina, OpenCVForUnity.BioinspiredModule.Retina>(owner);

            wrapped_owner.setupOPLandIPLParvoChannel(colorMode.Value, normaliseOutput.Value, photoreceptorsLocalAdaptationSensitivity.Value, photoreceptorsTemporalConstant.Value, photoreceptorsSpatialConstant.Value, horizontalCellsGain.Value, HcellsTemporalConstant.Value, HcellsSpatialConstant.Value);


        }

    }

}
