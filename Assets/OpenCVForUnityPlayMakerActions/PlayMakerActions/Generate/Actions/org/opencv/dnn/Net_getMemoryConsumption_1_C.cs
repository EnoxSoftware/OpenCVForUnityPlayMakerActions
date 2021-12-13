#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public void getMemoryConsumption(int layerId, List<MatOfInt> netInputShapes, long[] weights, long[] blobs)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Net), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "layerId")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "netInputShapes")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "weights")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "blobs")]
    public class Net_getMemoryConsumption_1_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] Net")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Net))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt layerId;

        [HutongGames.PlayMaker.ActionSection("[arg2] List<MatOfInt>(Array(MatOfInt))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor(typeof(OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmArray netInputShapes;

        [HutongGames.PlayMaker.ActionSection("[arg3] long[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray weights;

        [HutongGames.PlayMaker.ActionSection("[arg4] long[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray blobs;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            layerId = 0;
            netInputShapes = null;
            weights = null;
            blobs = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoProcess();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoProcess();
        }

        void DoProcess()
        {

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Net))
            {
                LogError("owner is not initialized. Add Action \"newNet\".");
                return;
            }
            OpenCVForUnity.DnnModule.Net wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Net, OpenCVForUnity.DnnModule.Net>(owner);

            List<OpenCVForUnity.CoreModule.MatOfInt> wrapped_netInputShapes = new List<OpenCVForUnity.CoreModule.MatOfInt>();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.CoreModule.MatOfInt>(netInputShapes, wrapped_netInputShapes);

            int[] int_weights = weights.intValues;
            long[] casted_weights = new long[int_weights.Length];
            int_weights.CopyTo(casted_weights, 0);

            int[] int_blobs = blobs.intValues;
            long[] casted_blobs = new long[int_blobs.Length];
            int_blobs.CopyTo(casted_blobs, 0);

            wrapped_owner.getMemoryConsumption(layerId.Value, wrapped_netInputShapes, casted_weights, casted_blobs);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.CoreModule.MatOfInt, OpenCVForUnityPlayMakerActions.MatOfInt>(wrapped_netInputShapes, netInputShapes);

            for (int i = 0; i < casted_weights.Length; i++)
            {
                weights.Set(i, (int)casted_weights[i]);
            }
            weights.SaveChanges();

            for (int i = 0; i < casted_blobs.Length; i++)
            {
                blobs.Set(i, (int)casted_blobs[i]);
            }
            blobs.SaveChanges();


        }

    }

}
#endif
