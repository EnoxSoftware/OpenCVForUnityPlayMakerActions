using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip("public static SparsePyrLKOpticalFlow create()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow), "storeResult")]
    public class SparsePyrLKOpticalFlow_create_5 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] SparsePyrLKOpticalFlow")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow)) storeResult.Value = new OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow();
            ((OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow)storeResult.Value).wrappedObject = OpenCVForUnity.VideoModule.SparsePyrLKOpticalFlow.create();


        }

    }

}
