#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public static Net readNetFromModelOptimizer(MatOfByte bufferModelConfig, MatOfByte bufferWeights)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfByte), "bufferModelConfig")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfByte), "bufferWeights")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Net), "storeResult")]
    public class Dnn_readNetFromModelOptimizer_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] MatOfByte")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfByte))]
        public HutongGames.PlayMaker.FsmObject bufferModelConfig;

        [HutongGames.PlayMaker.ActionSection("[arg2] MatOfByte")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfByte))]
        public HutongGames.PlayMaker.FsmObject bufferWeights;

        [HutongGames.PlayMaker.ActionSection("[return] Net")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Net))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            bufferModelConfig = null;
            bufferWeights = null;
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

            if (!(bufferModelConfig.Value is OpenCVForUnityPlayMakerActions.MatOfByte))
            {
                LogError("bufferModelConfig is not initialized. Add Action \"newMatOfByte\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfByte wrapped_bufferModelConfig = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfByte, OpenCVForUnity.CoreModule.MatOfByte>(bufferModelConfig);

            if (!(bufferWeights.Value is OpenCVForUnityPlayMakerActions.MatOfByte))
            {
                LogError("bufferWeights is not initialized. Add Action \"newMatOfByte\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfByte wrapped_bufferWeights = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfByte, OpenCVForUnity.CoreModule.MatOfByte>(bufferWeights);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Net)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Net();
            ((OpenCVForUnityPlayMakerActions.Net)storeResult.Value).wrappedObject = OpenCVForUnity.DnnModule.Dnn.readNetFromModelOptimizer(wrapped_bufferModelConfig, wrapped_bufferWeights);


        }

    }

}
#endif
