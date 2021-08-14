using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip("public static SimpleBlobDetector create(SimpleBlobDetector_Params parameters)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params), "parameters")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.SimpleBlobDetector), "storeResult")]
    public class SimpleBlobDetector_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] SimpleBlobDetector_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params))]
        public HutongGames.PlayMaker.FsmObject parameters;

        [HutongGames.PlayMaker.ActionSection("[return] SimpleBlobDetector")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.SimpleBlobDetector))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            parameters = null;
            storeResult = null;
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

            if (!(parameters.Value is OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params))
            {
                LogError("parameters is not initialized. Add Action \"newSimpleBlobDetector_Params\".");
                return;
            }
            OpenCVForUnity.Features2dModule.SimpleBlobDetector_Params wrapped_parameters = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params, OpenCVForUnity.Features2dModule.SimpleBlobDetector_Params>(parameters);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.SimpleBlobDetector)) storeResult.Value = new OpenCVForUnityPlayMakerActions.SimpleBlobDetector();
            ((OpenCVForUnityPlayMakerActions.SimpleBlobDetector)storeResult.Value).wrappedObject = OpenCVForUnity.Features2dModule.SimpleBlobDetector.create(wrapped_parameters);


        }

    }

}
