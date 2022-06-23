#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip("public static OCRBeamSearchDecoder_ClassifierCallback loadOCRBeamSearchClassifierCNN(string filename)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "filename")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback), "storeResult")]
    public class Text_loadOCRBeamSearchClassifierCNN : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString filename;

        [HutongGames.PlayMaker.ActionSection("[return] OCRBeamSearchDecoder_ClassifierCallback")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            filename = null;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback)) storeResult.Value = new OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback();
            ((OpenCVForUnityPlayMakerActions.OCRBeamSearchDecoder_ClassifierCallback)storeResult.Value).wrappedObject = OpenCVForUnity.TextModule.Text.loadOCRBeamSearchClassifierCNN(filename.Value);


        }

    }

}
#endif
