using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public Moments (double[] vals)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "vals")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Moments), "storeResult")]
    public class Moments_newMoments_1_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray vals;

        [HutongGames.PlayMaker.ActionSection ("[return] Moments")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Moments))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Moments)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Moments ();
            ((OpenCVForUnityPlayMakerActions.Moments)storeResult.Value).wrappedObject = new OpenCVForUnity.Moments (casted_vals);

            for (int i = 0; i < casted_vals.Length; i++)
            {
                float_vals[i] = (float)casted_vals[i];
            }


        }

    }

}
