using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Structured_lightModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_structured_light")]
    [HutongGames.PlayMaker.Tooltip("public static GrayCodePattern create(int width, int height)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "width")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "height")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.GrayCodePattern), "storeResult")]
    public class GrayCodePattern_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt width;

        [HutongGames.PlayMaker.ActionSection("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt height;

        [HutongGames.PlayMaker.ActionSection("[return] GrayCodePattern")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.GrayCodePattern))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            width = 0;
            height = 0;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.GrayCodePattern)) storeResult.Value = new OpenCVForUnityPlayMakerActions.GrayCodePattern();
            ((OpenCVForUnityPlayMakerActions.GrayCodePattern)storeResult.Value).wrappedObject = OpenCVForUnity.Structured_lightModule.GrayCodePattern.create(width.Value, height.Value);


        }

    }

}
