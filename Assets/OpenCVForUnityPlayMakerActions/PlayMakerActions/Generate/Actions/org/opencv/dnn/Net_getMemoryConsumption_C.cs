#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip ("public void getMemoryConsumption (MatOfInt netInputShape, long[] weights, long[] blobs)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Net), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "netInputShape")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "weights")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "blobs")]
    public class Net_getMemoryConsumption_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] Net")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Net))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfInt")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmObject netInputShape;

        [HutongGames.PlayMaker.ActionSection ("[arg2] long[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray weights;

        [HutongGames.PlayMaker.ActionSection ("[arg3] long[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray blobs;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            netInputShape = null;
            weights = null;
            blobs = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Net))
            {
                LogError ("owner is not initialized. Add Action \"newNet\".");
                return;
            }
            OpenCVForUnity.Net wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Net, OpenCVForUnity.Net> (owner);

            if (!(netInputShape.Value is OpenCVForUnityPlayMakerActions.MatOfInt))
            {
                LogError ("netInputShape is not initialized. Add Action \"newMatOfInt\".");
                return;
            }
            OpenCVForUnity.MatOfInt wrapped_netInputShape = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (netInputShape);

            int[] int_weights = weights.intValues;
            long[] casted_weights = new long[int_weights.Length];
            int_weights.CopyTo (casted_weights, 0);

            int[] int_blobs = blobs.intValues;
            long[] casted_blobs = new long[int_blobs.Length];
            int_blobs.CopyTo (casted_blobs, 0);

            wrapped_owner.getMemoryConsumption (wrapped_netInputShape, casted_weights, casted_blobs);

            for (int i = 0; i < casted_weights.Length; i++)
            {
                int_weights[i] = (int)casted_weights[i];
            }

            for (int i = 0; i < casted_blobs.Length; i++)
            {
                int_blobs[i] = (int)casted_blobs[i];
            }


        }

    }

}
#endif
