using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_bgsegm")]
    [HutongGames.PlayMaker.Tooltip ("public static BackgroundSubtractorGMG createBackgroundSubtractorGMG ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG), "storeResult")]
    public class Bgsegm_createBackgroundSubtractorGMG_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[return] BackgroundSubtractorGMG")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG)) storeResult.Value = new OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG ();
            ((OpenCVForUnityPlayMakerActions.BackgroundSubtractorGMG)storeResult.Value).wrappedObject = OpenCVForUnity.Bgsegm.createBackgroundSubtractorGMG ();


        }

    }

}
