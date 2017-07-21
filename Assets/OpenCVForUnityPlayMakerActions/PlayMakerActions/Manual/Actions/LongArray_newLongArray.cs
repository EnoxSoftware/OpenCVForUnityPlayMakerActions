using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public LongArray newLongArray (int[] array)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.LongArray), "storeResult")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "array")]
    public class LongArray_newLongArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray
            array;

        [HutongGames.PlayMaker.ActionSection ("[return] LongArray")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.LongArray))]
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
            int[] int_array = array.intValues;
            long[] casted_array = new long[int_array.Length];
            //            for (int i = 0; i < casted_array.Length; i++) {
            //                casted_array [i] = (long)int_array [i];
            //            }
            int_array.CopyTo (casted_array, 0);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.LongArray))
                storeResult.Value = new OpenCVForUnityPlayMakerActions.LongArray (new System.Int64[0]);
            ((OpenCVForUnityPlayMakerActions.LongArray)storeResult.Value).wrappedObject = casted_array;

        }

    }

}
