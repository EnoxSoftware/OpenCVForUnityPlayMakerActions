using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public IntelligentScissorsMB setEdgeFeatureZeroCrossingParameters(float gradient_magnitude_min_value)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "gradient_magnitude_min_value")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB), "storeResult")]
    public class IntelligentScissorsMB_setEdgeFeatureZeroCrossingParameters : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] IntelligentScissorsMB")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.IntelligentScissorsMB))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat gradient_magnitude_min_value;

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
            gradient_magnitude_min_value = 0.0f;
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
            ((OpenCVForUnityPlayMakerActions.IntelligentScissorsMB)storeResult.Value).wrappedObject = wrapped_owner.setEdgeFeatureZeroCrossingParameters(gradient_magnitude_min_value.Value);


        }

    }

}
