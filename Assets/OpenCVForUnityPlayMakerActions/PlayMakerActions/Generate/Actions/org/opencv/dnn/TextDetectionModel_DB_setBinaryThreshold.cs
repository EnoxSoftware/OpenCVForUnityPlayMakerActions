#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public TextDetectionModel_DB setBinaryThreshold(float binaryThreshold)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "binaryThreshold")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB), "storeResult")]
    public class TextDetectionModel_DB_setBinaryThreshold : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] TextDetectionModel_DB")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TextDetectionModel_DB))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat binaryThreshold;

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
            binaryThreshold = 0.0f;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TextDetectionModel_DB)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TextDetectionModel_DB();
            ((OpenCVForUnityPlayMakerActions.TextDetectionModel_DB)storeResult.Value).wrappedObject = wrapped_owner.setBinaryThreshold(binaryThreshold.Value);


        }

    }

}
#endif
