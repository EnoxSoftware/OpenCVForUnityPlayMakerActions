#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip("public static OCRHMMDecoder create(OCRHMMDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.OCRHMMDecoder_ClassifierCallback), "classifier")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "vocabulary")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "transition_probabilities_table")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "emission_probabilities_table")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "mode")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.OCRHMMDecoder), "storeResult")]
    public class OCRHMMDecoder_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] OCRHMMDecoder_ClassifierCallback")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.OCRHMMDecoder_ClassifierCallback))]
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

        [HutongGames.PlayMaker.ActionSection("[return] OCRHMMDecoder")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.OCRHMMDecoder))]
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

            if (!(classifier.Value is OpenCVForUnityPlayMakerActions.OCRHMMDecoder_ClassifierCallback))
            {
                LogError("classifier is not initialized. Add Action \"newOCRHMMDecoder_ClassifierCallback\".");
                return;
            }
            OpenCVForUnity.TextModule.OCRHMMDecoder_ClassifierCallback wrapped_classifier = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.OCRHMMDecoder_ClassifierCallback, OpenCVForUnity.TextModule.OCRHMMDecoder_ClassifierCallback>(classifier);

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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.OCRHMMDecoder)) storeResult.Value = new OpenCVForUnityPlayMakerActions.OCRHMMDecoder();
            ((OpenCVForUnityPlayMakerActions.OCRHMMDecoder)storeResult.Value).wrappedObject = OpenCVForUnity.TextModule.OCRHMMDecoder.create(wrapped_classifier, vocabulary.Value, wrapped_transition_probabilities_table, wrapped_emission_probabilities_table, mode.Value);


        }

    }

}
#endif
