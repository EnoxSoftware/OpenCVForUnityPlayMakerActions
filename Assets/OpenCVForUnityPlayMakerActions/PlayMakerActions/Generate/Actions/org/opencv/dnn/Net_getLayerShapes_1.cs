#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip ("public void getLayerShapes (List<MatOfInt> netInputShapes, int layerId, List<MatOfInt> inLayerShapes, List<MatOfInt> outLayerShapes)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Net), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "netInputShapes")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "layerId")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "inLayerShapes")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "outLayerShapes")]
    public class Net_getLayerShapes_1 : HutongGames.PlayMaker.FsmStateAction
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

        [HutongGames.PlayMaker.ActionSection ("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt layerId;

        [HutongGames.PlayMaker.ActionSection ("[arg3] List<MatOfInt>(Array(MatOfInt))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmArray inLayerShapes;

        [HutongGames.PlayMaker.ActionSection ("[arg4] List<MatOfInt>(Array(MatOfInt))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmArray outLayerShapes;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            netInputShapes = null;
            layerId = 0;
            inLayerShapes = null;
            outLayerShapes = null;
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

            List<OpenCVForUnity.MatOfInt> wrapped_inLayerShapes = new List<OpenCVForUnity.MatOfInt> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (inLayerShapes, wrapped_inLayerShapes);

            List<OpenCVForUnity.MatOfInt> wrapped_outLayerShapes = new List<OpenCVForUnity.MatOfInt> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (outLayerShapes, wrapped_outLayerShapes);

            wrapped_owner.getLayerShapes (wrapped_netInputShapes, layerId.Value, wrapped_inLayerShapes, wrapped_outLayerShapes);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfInt, OpenCVForUnityPlayMakerActions.MatOfInt> (wrapped_netInputShapes, netInputShapes);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfInt, OpenCVForUnityPlayMakerActions.MatOfInt> (wrapped_inLayerShapes, inLayerShapes);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfInt, OpenCVForUnityPlayMakerActions.MatOfInt> (wrapped_outLayerShapes, outLayerShapes);


        }

    }

}
#endif
