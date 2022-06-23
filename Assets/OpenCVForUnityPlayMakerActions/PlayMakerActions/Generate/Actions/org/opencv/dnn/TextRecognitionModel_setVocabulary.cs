#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public TextRecognitionModel setVocabulary(List<string> vocabulary)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TextRecognitionModel), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "vocabulary")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.TextRecognitionModel), "storeResult")]
    public class TextRecognitionModel_setVocabulary : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] TextRecognitionModel")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TextRecognitionModel))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] List<string>(Array(string))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.String)]
        public HutongGames.PlayMaker.FsmArray vocabulary;

        [HutongGames.PlayMaker.ActionSection("[return] TextRecognitionModel")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.TextRecognitionModel))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            vocabulary = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.TextRecognitionModel))
            {
                LogError("owner is not initialized. Add Action \"newTextRecognitionModel\".");
                return;
            }
            OpenCVForUnity.DnnModule.TextRecognitionModel wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TextRecognitionModel, OpenCVForUnity.DnnModule.TextRecognitionModel>(owner);

            string[] string_vocabulary = vocabulary.stringValues;
            List<string> wrapped_vocabulary = new List<string>(string_vocabulary);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TextRecognitionModel)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TextRecognitionModel();
            ((OpenCVForUnityPlayMakerActions.TextRecognitionModel)storeResult.Value).wrappedObject = wrapped_owner.setVocabulary(wrapped_vocabulary);

            for (int i = 0; i < wrapped_vocabulary.Count; i++)
            {
                vocabulary.Set(i, (string)wrapped_vocabulary[i]);
            }
            vocabulary.SaveChanges();


        }

    }

}
#endif
