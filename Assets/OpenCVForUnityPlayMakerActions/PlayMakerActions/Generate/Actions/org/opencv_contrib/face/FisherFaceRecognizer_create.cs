using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_face")]
    [HutongGames.PlayMaker.Tooltip("public static FisherFaceRecognizer create(int num_components, double threshold)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "num_components")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "threshold")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.FisherFaceRecognizer), "storeResult")]
    public class FisherFaceRecognizer_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt num_components;

        [HutongGames.PlayMaker.ActionSection("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject threshold;

        [HutongGames.PlayMaker.ActionSection("[return] FisherFaceRecognizer")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.FisherFaceRecognizer))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            num_components = 0;
            threshold = null;
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

            if (!(threshold.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("threshold is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_threshold = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(threshold);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.FisherFaceRecognizer)) storeResult.Value = new OpenCVForUnityPlayMakerActions.FisherFaceRecognizer();
            ((OpenCVForUnityPlayMakerActions.FisherFaceRecognizer)storeResult.Value).wrappedObject = OpenCVForUnity.FaceModule.FisherFaceRecognizer.create(num_components.Value, wrapped_threshold);


        }

    }

}
