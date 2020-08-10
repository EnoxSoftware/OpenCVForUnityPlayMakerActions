using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public DoubleArray newDoubleArray (float[] array)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "array")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DoubleArray), "storeResult")]
    public class DoubleArray_newDoubleArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] float[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray
            array;

        [HutongGames.PlayMaker.ActionSection ("[return] DoubleArray")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DoubleArray))]
        public HutongGames.PlayMaker.FsmObject
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {

            array = null;
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
            float[] float_array = array.floatValues;
            double[] casted_array = new double[float_array.Length];
            //            for (int i = 0; i < casted_array.Length; i++) {
            //                casted_array [i] = (double)float_array [i];
            //            }
            float_array.CopyTo (casted_array, 0);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.DoubleArray))
                storeResult.Value = new OpenCVForUnityPlayMakerActions.DoubleArray (new System.Double[0]);
            ((OpenCVForUnityPlayMakerActions.DoubleArray)storeResult.Value).wrappedObject = casted_array;

        }

    }

}
