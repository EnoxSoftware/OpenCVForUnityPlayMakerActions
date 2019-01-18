using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_optflow")]
    [HutongGames.PlayMaker.Tooltip ("public static DualTVL1OpticalFlow create (double tau, double lambda)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "tau")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "lambda")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DualTVL1OpticalFlow), "storeResult")]
    public class DualTVL1OpticalFlow_create_10 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject tau;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject lambda;

        [HutongGames.PlayMaker.ActionSection ("[return] DualTVL1OpticalFlow")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DualTVL1OpticalFlow))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            tau = null;
            lambda = null;
            storeResult = null;
            everyFrame = false;
        }

        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame)
            {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {

            if (!(tau.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("tau is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_tau = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (tau);

            if (!(lambda.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("lambda is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_lambda = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (lambda);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.DualTVL1OpticalFlow)) storeResult.Value = new OpenCVForUnityPlayMakerActions.DualTVL1OpticalFlow ();
            ((OpenCVForUnityPlayMakerActions.DualTVL1OpticalFlow)storeResult.Value).wrappedObject = OpenCVForUnity.OptflowModule.DualTVL1OpticalFlow.create (wrapped_tau, wrapped_lambda);


        }

    }

}
