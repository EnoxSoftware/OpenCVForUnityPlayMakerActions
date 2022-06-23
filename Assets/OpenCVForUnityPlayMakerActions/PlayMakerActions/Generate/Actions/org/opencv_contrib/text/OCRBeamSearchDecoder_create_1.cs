#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip("public static OCRBeamSearchDecoder create(OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback), "classifier")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "vocabulary")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "transition_probabilities_table")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "emission_probabilities_table")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "mode")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder), "storeResult")]
    public class OCRBeamSearchDecoder_create_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] OCRBeamSearchDecoder_ClassifierCallback")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback))]
        public HutongGames.PlayMaker.FsmObject classifier;

        [HutongGames.PlayMaker.ActionSection("[arg2] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString vocabulary;

        [HutongGames.PlayMaker.ActionSection("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject transition_probabilities_table;

        [HutongGames.PlayMaker.ActionSection("[arg4] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject emission_probabilities_table;

        [HutongGames.PlayMaker.ActionSection("[arg5] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt mode;

        [HutongGames.PlayMaker.ActionSection("[return] OCRBeamSearchDecoder")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            classifier = null;
            vocabulary = null;
            transition_probabilities_table = null;
            emission_probabilities_table = null;
            mode = 0;
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

            if (!(classifier.Value is OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback))
            {
                LogError("classifier is not initialized. Add Action \"newOCRBeamSearchDecoder_ClassifierCallback\".");
                return;
            }
            OpenCVForUnity.TextModule.OCRBeamSearchDecoder_ClassifierCallback wrapped_classifier = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback, OpenCVForUnity.TextModule.OCRBeamSearchDecoder_ClassifierCallback>(classifier);

            if (!(transition_probabilities_table.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("transition_probabilities_table is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_transition_probabilities_table = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(transition_probabilities_table);

            if (!(emission_probabilities_table.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("emission_probabilities_table is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_emission_probabilities_table = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(emission_probabilities_table);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder)) storeResult.Value = new OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder();
            ((OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder)storeResult.Value).wrappedObject = OpenCVForUnity.TextModule.OCRBeamSearchDecoder.create(wrapped_classifier, vocabulary.Value, wrapped_transition_probabilities_table, wrapped_emission_probabilities_table, mode.Value);


        }

    }

}
#endif
