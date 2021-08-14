#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip("public static ERFilter createERFilterNM1(ERFilter_Callback cb, int thresholdDelta, float minArea, float maxArea)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.ERFilter_Callback), "cb")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "thresholdDelta")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "minArea")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "maxArea")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.ERFilter), "storeResult")]
    public class Text_createERFilterNM1_3 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] ERFilter_Callback")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.ERFilter_Callback))]
        public HutongGames.PlayMaker.FsmObject cb;

        [HutongGames.PlayMaker.ActionSection("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt thresholdDelta;

        [HutongGames.PlayMaker.ActionSection("[arg3] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat minArea;

        [HutongGames.PlayMaker.ActionSection("[arg4] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat maxArea;

        [HutongGames.PlayMaker.ActionSection("[return] ERFilter")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.ERFilter))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            cb = null;
            thresholdDelta = 0;
            minArea = 0.0f;
            maxArea = 0.0f;
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

            if (!(cb.Value is OpenCVForUnityPlayMakerActions.ERFilter_Callback))
            {
                LogError("cb is not initialized. Add Action \"newERFilter_Callback\".");
                return;
            }
            OpenCVForUnity.TextModule.ERFilter_Callback wrapped_cb = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ERFilter_Callback, OpenCVForUnity.TextModule.ERFilter_Callback>(cb);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.ERFilter)) storeResult.Value = new OpenCVForUnityPlayMakerActions.ERFilter();
            ((OpenCVForUnityPlayMakerActions.ERFilter)storeResult.Value).wrappedObject = OpenCVForUnity.TextModule.Text.createERFilterNM1(wrapped_cb, thresholdDelta.Value, minArea.Value, maxArea.Value);


        }

    }

}
#endif
