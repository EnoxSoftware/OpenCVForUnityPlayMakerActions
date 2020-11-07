using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip("public void setViewParams(MatOfFloat tilts, MatOfFloat rolls)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.AffineFeature), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat), "tilts")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat), "rolls")]
    public class AffineFeature_setViewParams : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] AffineFeature")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.AffineFeature))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] MatOfFloat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat))]
        public HutongGames.PlayMaker.FsmObject tilts;

        [HutongGames.PlayMaker.ActionSection("[arg2] MatOfFloat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat))]
        public HutongGames.PlayMaker.FsmObject rolls;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            tilts = null;
            rolls = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.AffineFeature))
            {
                LogError("owner is not initialized. Add Action \"newAffineFeature\".");
                return;
            }
            OpenCVForUnity.Features2dModule.AffineFeature wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.AffineFeature, OpenCVForUnity.Features2dModule.AffineFeature>(owner);

            if (!(tilts.Value is OpenCVForUnityPlayMakerActions.MatOfFloat))
            {
                LogError("tilts is not initialized. Add Action \"newMatOfFloat\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfFloat wrapped_tilts = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfFloat, OpenCVForUnity.CoreModule.MatOfFloat>(tilts);

            if (!(rolls.Value is OpenCVForUnityPlayMakerActions.MatOfFloat))
            {
                LogError("rolls is not initialized. Add Action \"newMatOfFloat\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfFloat wrapped_rolls = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfFloat, OpenCVForUnity.CoreModule.MatOfFloat>(rolls);

            wrapped_owner.setViewParams(wrapped_tilts, wrapped_rolls);


        }

    }

}
