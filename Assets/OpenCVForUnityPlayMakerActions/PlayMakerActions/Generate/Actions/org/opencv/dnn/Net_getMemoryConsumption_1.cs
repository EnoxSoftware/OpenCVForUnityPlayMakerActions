#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip ("public void getMemoryConsumption (MatOfInt netInputShape, MatOfInt layerIds, MatOfDouble weights, MatOfDouble blobs)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Net), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "netInputShape")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "layerIds")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDouble), "weights")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDouble), "blobs")]
    public class Net_getMemoryConsumption_1 : HutongGames.PlayMaker.FsmStateAction
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

        [HutongGames.PlayMaker.ActionSection ("[arg2] MatOfInt")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmObject layerIds;

        [HutongGames.PlayMaker.ActionSection ("[arg3] MatOfDouble")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDouble))]
        public HutongGames.PlayMaker.FsmObject weights;

        [HutongGames.PlayMaker.ActionSection ("[arg4] MatOfDouble")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDouble))]
        public HutongGames.PlayMaker.FsmObject blobs;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            netInputShape = null;
            layerIds = null;
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

            if (!(layerIds.Value is OpenCVForUnityPlayMakerActions.MatOfInt))
            {
                LogError ("layerIds is not initialized. Add Action \"newMatOfInt\".");
                return;
            }
            OpenCVForUnity.MatOfInt wrapped_layerIds = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (layerIds);

            if (!(weights.Value is OpenCVForUnityPlayMakerActions.MatOfDouble))
            {
                LogError ("weights is not initialized. Add Action \"newMatOfDouble\".");
                return;
            }
            OpenCVForUnity.MatOfDouble wrapped_weights = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDouble, OpenCVForUnity.MatOfDouble> (weights);

            if (!(blobs.Value is OpenCVForUnityPlayMakerActions.MatOfDouble))
            {
                LogError ("blobs is not initialized. Add Action \"newMatOfDouble\".");
                return;
            }
            OpenCVForUnity.MatOfDouble wrapped_blobs = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDouble, OpenCVForUnity.MatOfDouble> (blobs);

            wrapped_owner.getMemoryConsumption (wrapped_netInputShape, wrapped_layerIds, wrapped_weights, wrapped_blobs);


        }

    }

}
#endif
