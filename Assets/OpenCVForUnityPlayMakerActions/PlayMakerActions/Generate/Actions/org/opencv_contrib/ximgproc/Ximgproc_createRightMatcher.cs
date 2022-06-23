using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip("public static StereoMatcher createRightMatcher(StereoMatcher matcher_left)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.StereoMatcher), "matcher_left")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.StereoMatcher), "storeResult")]
    public class Ximgproc_createRightMatcher : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] StereoMatcher")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.StereoMatcher))]
        public HutongGames.PlayMaker.FsmObject matcher_left;

        [HutongGames.PlayMaker.ActionSection("[return] StereoMatcher")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.StereoMatcher))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            matcher_left = null;
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

            if (!(matcher_left.Value is OpenCVForUnityPlayMakerActions.StereoMatcher))
            {
                LogError("matcher_left is not initialized. Add Action \"newStereoMatcher\".");
                return;
            }
            OpenCVForUnity.Calib3dModule.StereoMatcher wrapped_matcher_left = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.StereoMatcher, OpenCVForUnity.Calib3dModule.StereoMatcher>(matcher_left);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.StereoMatcher)) storeResult.Value = new OpenCVForUnityPlayMakerActions.StereoMatcher();
            ((OpenCVForUnityPlayMakerActions.StereoMatcher)storeResult.Value).wrappedObject = OpenCVForUnity.XimgprocModule.Ximgproc.createRightMatcher(wrapped_matcher_left);


        }

    }

}
