using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_objdetect")]
    [HutongGames.PlayMaker.Tooltip("public void setCharucoParameters(CharucoParameters charucoParameters)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.CharucoDetector), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.CharucoParameters), "charucoParameters")]
    public class CharucoDetector_setCharucoParameters : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] CharucoDetector")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.CharucoDetector))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] CharucoParameters")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.CharucoParameters))]
        public HutongGames.PlayMaker.FsmObject charucoParameters;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            charucoParameters = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.CharucoDetector))
            {
                LogError("owner is not initialized. Add Action \"newCharucoDetector\".");
                return;
            }
            OpenCVForUnity.ObjdetectModule.CharucoDetector wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.CharucoDetector, OpenCVForUnity.ObjdetectModule.CharucoDetector>(owner);

            if (!(charucoParameters.Value is OpenCVForUnityPlayMakerActions.CharucoParameters))
            {
                LogError("charucoParameters is not initialized. Add Action \"newCharucoParameters\".");
                return;
            }
            OpenCVForUnity.ObjdetectModule.CharucoParameters wrapped_charucoParameters = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.CharucoParameters, OpenCVForUnity.ObjdetectModule.CharucoParameters>(charucoParameters);

            wrapped_owner.setCharucoParameters(wrapped_charucoParameters);


        }

    }

}
