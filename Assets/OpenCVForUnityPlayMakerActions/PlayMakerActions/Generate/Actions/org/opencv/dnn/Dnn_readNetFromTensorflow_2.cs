#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip ("public static Net readNetFromTensorflow (MatOfByte bufferModel, MatOfByte bufferConfig)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfByte), "bufferModel")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfByte), "bufferConfig")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Net), "storeResult")]
    public class Dnn_readNetFromTensorflow_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfByte")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfByte))]
        public HutongGames.PlayMaker.FsmObject bufferModel;

        [HutongGames.PlayMaker.ActionSection ("[arg2] MatOfByte")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfByte))]
        public HutongGames.PlayMaker.FsmObject bufferConfig;

        [HutongGames.PlayMaker.ActionSection ("[return] Net")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Net))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            bufferModel = null;
            bufferConfig = null;
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

            if (!(bufferModel.Value is OpenCVForUnityPlayMakerActions.MatOfByte))
            {
                LogError ("bufferModel is not initialized. Add Action \"newMatOfByte\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfByte wrapped_bufferModel = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfByte, OpenCVForUnity.CoreModule.MatOfByte> (bufferModel);

            if (!(bufferConfig.Value is OpenCVForUnityPlayMakerActions.MatOfByte))
            {
                LogError ("bufferConfig is not initialized. Add Action \"newMatOfByte\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfByte wrapped_bufferConfig = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfByte, OpenCVForUnity.CoreModule.MatOfByte> (bufferConfig);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Net)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Net ();
            ((OpenCVForUnityPlayMakerActions.Net)storeResult.Value).wrappedObject = OpenCVForUnity.DnnModule.Dnn.readNetFromTensorflow (wrapped_bufferModel, wrapped_bufferConfig);


        }

    }

}
#endif
