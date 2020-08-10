using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public ByteArray newByteArray (int[] array)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "array")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ByteArray), "storeResult")]
    public class ByteArray_newByteArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray
            array;

        [HutongGames.PlayMaker.ActionSection ("[return] ByteArray")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ByteArray))]
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
            byte[] casted_array = new byte[int_array.Length];
            for (int i = 0; i < casted_array.Length; i++)
            {
                casted_array[i] = (byte)int_array[i];
            }

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.ByteArray))
                storeResult.Value = new OpenCVForUnityPlayMakerActions.ByteArray (new System.Byte[0]);
            ((OpenCVForUnityPlayMakerActions.ByteArray)storeResult.Value).wrappedObject = casted_array;

        }

    }

}
