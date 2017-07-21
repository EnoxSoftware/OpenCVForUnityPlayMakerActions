using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static BackgroundSubtractorGMG createBackgroundSubtractorGMG (int initializationFrames, double decisionThreshold)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "initializationFrames")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "decisionThreshold")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG), "storeResult")]
    public class Bgsegm_createBackgroundSubtractorGMG : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt initializationFrames;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject decisionThreshold;

        [HutongGames.PlayMaker.ActionSection ("[return] BackgroundSubtractorGMG")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            initializationFrames = 0;
            decisionThreshold = null;
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

            if (!(decisionThreshold.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("decisionThreshold is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_decisionThreshold = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (decisionThreshold);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG)) storeResult.Value = new OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG ();
            ((OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG)storeResult.Value).wrappedObject = OpenCVForUnity.Bgsegm.createBackgroundSubtractorGMG (initializationFrames.Value, wrapped_decisionThreshold);


        }

    }

}
