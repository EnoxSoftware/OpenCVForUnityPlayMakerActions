#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip ("public void getMemoryConsumption (List<MatOfInt> netInputShapes, long[] weights, long[] blobs)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Net), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "netInputShapes")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.LongArray), "weights")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.LongArray), "blobs")]
    public class Net_getMemoryConsumption_4 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] Net")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Net))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] List<MatOfInt>(Array(MatOfInt))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmArray netInputShapes;

        [HutongGames.PlayMaker.ActionSection ("[arg2] long[](LongArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.LongArray))]
        public HutongGames.PlayMaker.FsmObject weights;

        [HutongGames.PlayMaker.ActionSection ("[arg3] long[](LongArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.LongArray))]
        public HutongGames.PlayMaker.FsmObject blobs;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            netInputShapes = null;
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

            List<OpenCVForUnity.MatOfInt> wrapped_netInputShapes = new List<OpenCVForUnity.MatOfInt> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (netInputShapes, wrapped_netInputShapes);

            if (!(weights.Value is OpenCVForUnityPlayMakerActions.LongArray))
            {
                LogError ("weights is not initialized. Add Action \"newLongArray\".");
                return;
            }
            System.Int64[] wrapped_weights = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.LongArray, System.Int64[]> (weights);

            if (!(blobs.Value is OpenCVForUnityPlayMakerActions.LongArray))
            {
                LogError ("blobs is not initialized. Add Action \"newLongArray\".");
                return;
            }
            System.Int64[] wrapped_blobs = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.LongArray, System.Int64[]> (blobs);

            wrapped_owner.getMemoryConsumption (wrapped_netInputShapes, wrapped_weights, wrapped_blobs);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfInt, OpenCVForUnityPlayMakerActions.MatOfInt> (wrapped_netInputShapes, netInputShapes);


        }

    }

}
#endif
