using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip("public static MSER create(int delta, int min_area, int max_area, double max_variation, double min_diversity, int max_evolution)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "delta")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "min_area")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "max_area")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "max_variation")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "min_diversity")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "max_evolution")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MSER), "storeResult")]
    public class MSER_create_3 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt delta;

        [HutongGames.PlayMaker.ActionSection("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt min_area;

        [HutongGames.PlayMaker.ActionSection("[arg3] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt max_area;

        [HutongGames.PlayMaker.ActionSection("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject max_variation;

        [HutongGames.PlayMaker.ActionSection("[arg5] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject min_diversity;

        [HutongGames.PlayMaker.ActionSection("[arg6] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt max_evolution;

        [HutongGames.PlayMaker.ActionSection("[return] MSER")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MSER))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            delta = 0;
            min_area = 0;
            max_area = 0;
            max_variation = null;
            min_diversity = null;
            max_evolution = 0;
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

            if (!(max_variation.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("max_variation is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_max_variation = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(max_variation);

            if (!(min_diversity.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("min_diversity is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_min_diversity = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(min_diversity);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MSER)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MSER();
            ((OpenCVForUnityPlayMakerActions.MSER)storeResult.Value).wrappedObject = OpenCVForUnity.Features2dModule.MSER.create(delta.Value, min_area.Value, max_area.Value, wrapped_max_variation, wrapped_min_diversity, max_evolution.Value);


        }

    }

}
