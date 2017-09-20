using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public RotatedRect (double[] vals)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DoubleArray), "vals")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.RotatedRect), "storeResult")]
    public class RotatedRect_newRotatedRect_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double[](DoubleArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DoubleArray))]
        public HutongGames.PlayMaker.FsmObject vals;

        [HutongGames.PlayMaker.ActionSection ("[return] RotatedRect")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.RotatedRect))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            vals = null;
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

            if (!(vals.Value is OpenCVForUnityPlayMakerActions.DoubleArray))
            {
                LogError ("vals is not initialized. Add Action \"newDoubleArray\".");
                return;
            }
            System.Double[] wrapped_vals = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.DoubleArray, System.Double[]> (vals);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.RotatedRect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.RotatedRect ();
            ((OpenCVForUnityPlayMakerActions.RotatedRect)storeResult.Value).wrappedObject = new OpenCVForUnity.RotatedRect (wrapped_vals);


        }

    }

}
