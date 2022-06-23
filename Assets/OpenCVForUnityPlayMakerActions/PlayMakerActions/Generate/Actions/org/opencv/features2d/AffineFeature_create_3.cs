using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip("public static AffineFeature create(Feature2D backend, int maxTilt)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Feature2D), "backend")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "maxTilt")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.AffineFeature), "storeResult")]
    public class AffineFeature_create_3 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] Feature2D")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Feature2D))]
        public HutongGames.PlayMaker.FsmObject backend;

        [HutongGames.PlayMaker.ActionSection("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt maxTilt;

        [HutongGames.PlayMaker.ActionSection("[return] AffineFeature")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.AffineFeature))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            backend = null;
            maxTilt = 0;
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

            if (!(backend.Value is OpenCVForUnityPlayMakerActions.Feature2D))
            {
                LogError("backend is not initialized. Add Action \"newFeature2D\".");
                return;
            }
            OpenCVForUnity.Features2dModule.Feature2D wrapped_backend = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Feature2D, OpenCVForUnity.Features2dModule.Feature2D>(backend);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.AffineFeature)) storeResult.Value = new OpenCVForUnityPlayMakerActions.AffineFeature();
            ((OpenCVForUnityPlayMakerActions.AffineFeature)storeResult.Value).wrappedObject = OpenCVForUnity.Features2dModule.AffineFeature.create(wrapped_backend, maxTilt.Value);


        }

    }

}
