using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public RotatedRect (double[] vals)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "vals")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.RotatedRect), "storeResult")]
    public class RotatedRect_newRotatedRect_2_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray vals;

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

            float[] float_vals = vals.floatValues;
            double[] casted_vals = new double[float_vals.Length];
            float_vals.CopyTo (casted_vals, 0);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.RotatedRect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.RotatedRect ();
            ((OpenCVForUnityPlayMakerActions.RotatedRect)storeResult.Value).wrappedObject = new OpenCVForUnity.RotatedRect (casted_vals);

            for (int i = 0; i < casted_vals.Length; i++)
            {
                float_vals[i] = (float)casted_vals[i];
            }


        }

    }

}
