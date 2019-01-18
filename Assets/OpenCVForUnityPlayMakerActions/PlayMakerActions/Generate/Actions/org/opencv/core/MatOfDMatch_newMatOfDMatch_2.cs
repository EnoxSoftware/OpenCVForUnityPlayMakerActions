using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public MatOfDMatch (params DMatch[] ap)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "ap")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch), "storeResult")]
    public class MatOfDMatch_newMatOfDMatch_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] DMatch[](Array(DMatch))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.DMatch))]
        public HutongGames.PlayMaker.FsmArray ap;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfDMatch")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            ap = null;
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

            OpenCVForUnity.CoreModule.DMatch[] wrapped_ap = new OpenCVForUnity.CoreModule.DMatch[ap.Length];
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToArray<OpenCVForUnityPlayMakerActions.DMatch, OpenCVForUnity.CoreModule.DMatch> (ap, wrapped_ap);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfDMatch)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfDMatch ();
            ((OpenCVForUnityPlayMakerActions.MatOfDMatch)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.MatOfDMatch (wrapped_ap);

            OpenCVForUnityPlayMakerActionsUtils.ConvertArrayToFsmArray<OpenCVForUnity.CoreModule.DMatch, OpenCVForUnityPlayMakerActions.DMatch> (wrapped_ap, ap);


        }

    }

}
