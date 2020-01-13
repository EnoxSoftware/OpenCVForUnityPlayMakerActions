#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip("public static OCRTesseract create(string datapath, string language, string char_whitelist)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "datapath")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "language")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "char_whitelist")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.OCRTesseract), "storeResult")]
    public class OCRTesseract_create_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString datapath;

        [HutongGames.PlayMaker.ActionSection("[arg2] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString language;

        [HutongGames.PlayMaker.ActionSection("[arg3] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString char_whitelist;

        [HutongGames.PlayMaker.ActionSection("[return] OCRTesseract")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.OCRTesseract))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            datapath = null;
            language = null;
            char_whitelist = null;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.OCRTesseract)) storeResult.Value = new OpenCVForUnityPlayMakerActions.OCRTesseract();
            ((OpenCVForUnityPlayMakerActions.OCRTesseract)storeResult.Value).wrappedObject = OpenCVForUnity.TextModule.OCRTesseract.create(datapath.Value, language.Value, char_whitelist.Value);


        }

    }

}
#endif
