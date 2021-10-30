#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public TextDetectionModel_DB setUnclipRatio(double unclipRatio)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "unclipRatio")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB), "storeResult")]
    public class TextDetectionModel_DB_setUnclipRatio : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] TextDetectionModel_DB")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject unclipRatio;

        [HutongGames.PlayMaker.ActionSection("[return] TextDetectionModel_DB")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            unclipRatio = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.TextDetectionModel_DB))
            {
                LogError("owner is not initialized. Add Action \"newTextDetectionModel_DB\".");
                return;
            }
            OpenCVForUnity.DnnModule.TextDetectionModel_DB wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TextDetectionModel_DB, OpenCVForUnity.DnnModule.TextDetectionModel_DB>(owner);

            if (!(unclipRatio.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("unclipRatio is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_unclipRatio = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(unclipRatio);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TextDetectionModel_DB)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TextDetectionModel_DB();
            ((OpenCVForUnityPlayMakerActions.TextDetectionModel_DB)storeResult.Value).wrappedObject = wrapped_owner.setUnclipRatio(wrapped_unclipRatio);


        }

    }

}
#endif
