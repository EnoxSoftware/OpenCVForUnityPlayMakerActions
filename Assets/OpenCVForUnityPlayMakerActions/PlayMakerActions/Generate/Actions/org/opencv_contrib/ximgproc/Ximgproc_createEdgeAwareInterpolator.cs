using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static EdgeAwareInterpolator createEdgeAwareInterpolator ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.EdgeAwareInterpolator), "storeResult")]
    public class Ximgproc_createEdgeAwareInterpolator : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[return] EdgeAwareInterpolator")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.EdgeAwareInterpolator))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.EdgeAwareInterpolator)) storeResult.Value = new OpenCVForUnityPlayMakerActions.EdgeAwareInterpolator ();
            ((OpenCVForUnityPlayMakerActions.EdgeAwareInterpolator)storeResult.Value).wrappedObject = OpenCVForUnity.Ximgproc.createEdgeAwareInterpolator ();


        }

    }

}
