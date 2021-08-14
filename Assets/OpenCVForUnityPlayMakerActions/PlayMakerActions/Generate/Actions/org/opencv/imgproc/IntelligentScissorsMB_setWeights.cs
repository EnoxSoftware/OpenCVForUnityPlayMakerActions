using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public IntelligentScissorsMB setWeights(float weight_non_edge, float weight_gradient_direction, float weight_gradient_magnitude)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "weight_non_edge")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "weight_gradient_direction")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "weight_gradient_magnitude")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB), "storeResult")]
    public class IntelligentScissorsMB_setWeights : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] IntelligentScissorsMB")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat weight_non_edge;

        [HutongGames.PlayMaker.ActionSection("[arg2] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat weight_gradient_direction;

        [HutongGames.PlayMaker.ActionSection("[arg3] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat weight_gradient_magnitude;

        [HutongGames.PlayMaker.ActionSection("[return] IntelligentScissorsMB")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            weight_non_edge = 0.0f;
            weight_gradient_direction = 0.0f;
            weight_gradient_magnitude = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.IntelligentScissorsMB))
            {
                LogError("owner is not initialized. Add Action \"newIntelligentScissorsMB\".");
                return;
            }
            OpenCVForUnity.ImgprocModule.IntelligentScissorsMB wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.IntelligentScissorsMB, OpenCVForUnity.ImgprocModule.IntelligentScissorsMB>(owner);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.IntelligentScissorsMB)) storeResult.Value = new OpenCVForUnityPlayMakerActions.IntelligentScissorsMB();
            ((OpenCVForUnityPlayMakerActions.IntelligentScissorsMB)storeResult.Value).wrappedObject = wrapped_owner.setWeights(weight_non_edge.Value, weight_gradient_direction.Value, weight_gradient_magnitude.Value);


        }

    }

}
