#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public void setInputParams(double scale, Size size, Scalar mean, bool swapRB)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Model), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "scale")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "size_width")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "size_height")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "mean_v0")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "mean_v1")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "mean_v2")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "mean_v3")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "swapRB")]
    public class Model_setInputParams_1_S : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] Model")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Model))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject scale;

        [HutongGames.PlayMaker.ActionSection("[arg2] Size")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat size_width;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat size_height;

        [HutongGames.PlayMaker.ActionSection("[arg3] Scalar")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat mean_v0;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat mean_v1;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat mean_v2;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat mean_v3;

        [HutongGames.PlayMaker.ActionSection("[arg4] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool swapRB;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            scale = null;
            size_width = 0.0f;
            size_height = 0.0f;
            mean_v0 = 0.0f;
            mean_v1 = 0.0f;
            mean_v2 = 0.0f;
            mean_v3 = 0.0f;
            swapRB = false;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Model))
            {
                LogError("owner is not initialized. Add Action \"newModel\".");
                return;
            }
            OpenCVForUnity.DnnModule.Model wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Model, OpenCVForUnity.DnnModule.Model>(owner);

            if (!(scale.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("scale is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_scale = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(scale);

            wrapped_owner.setInputParams(wrapped_scale, new OpenCVForUnity.CoreModule.Size((double)size_width.Value, (double)size_height.Value), new OpenCVForUnity.CoreModule.Scalar((double)mean_v0.Value, (double)mean_v1.Value, (double)mean_v2.Value, (double)mean_v3.Value), swapRB.Value);


        }

    }

}
#endif
