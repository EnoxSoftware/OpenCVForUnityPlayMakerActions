using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip("public static BackgroundSubtractorKNN createBackgroundSubtractorKNN(int history, double dist2Threshold, bool detectShadows)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "history")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "dist2Threshold")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "detectShadows")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.BackgroundSubtractorKNN), "storeResult")]
    public class Video_createBackgroundSubtractorKNN : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt history;

        [HutongGames.PlayMaker.ActionSection("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject dist2Threshold;

        [HutongGames.PlayMaker.ActionSection("[arg3] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool detectShadows;

        [HutongGames.PlayMaker.ActionSection("[return] BackgroundSubtractorKNN")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.BackgroundSubtractorKNN))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            history = 0;
            dist2Threshold = null;
            detectShadows = false;
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

            if (!(dist2Threshold.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("dist2Threshold is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_dist2Threshold = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(dist2Threshold);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.BackgroundSubtractorKNN)) storeResult.Value = new OpenCVForUnityPlayMakerActions.BackgroundSubtractorKNN();
            ((OpenCVForUnityPlayMakerActions.BackgroundSubtractorKNN)storeResult.Value).wrappedObject = OpenCVForUnity.VideoModule.Video.createBackgroundSubtractorKNN(history.Value, wrapped_dist2Threshold, detectShadows.Value);


        }

    }

}
