using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public static GeneralizedHoughBallard createGeneralizedHoughBallard()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.GeneralizedHoughBallard), "storeResult")]
    public class Imgproc_createGeneralizedHoughBallard : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] GeneralizedHoughBallard")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.GeneralizedHoughBallard))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.GeneralizedHoughBallard)) storeResult.Value = new OpenCVForUnityPlayMakerActions.GeneralizedHoughBallard();
            ((OpenCVForUnityPlayMakerActions.GeneralizedHoughBallard)storeResult.Value).wrappedObject = OpenCVForUnity.ImgprocModule.Imgproc.createGeneralizedHoughBallard();


        }

    }

}
