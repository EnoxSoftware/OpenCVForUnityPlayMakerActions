using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_objdetect")]
    [HutongGames.PlayMaker.Tooltip("public MatOfFloat get_svmDetector()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.HOGDescriptor), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat), "storeResult")]
    public class HOGDescriptor_get_svmDetector : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] HOGDescriptor")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.HOGDescriptor))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[return] MatOfFloat")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.HOGDescriptor))
            {
                LogError("owner is not initialized. Add Action \"newHOGDescriptor\".");
                return;
            }
            OpenCVForUnity.ObjdetectModule.HOGDescriptor wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.HOGDescriptor, OpenCVForUnity.ObjdetectModule.HOGDescriptor>(owner);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfFloat)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfFloat();
            ((OpenCVForUnityPlayMakerActions.MatOfFloat)storeResult.Value).wrappedObject = wrapped_owner.get_svmDetector();


        }

    }

}
