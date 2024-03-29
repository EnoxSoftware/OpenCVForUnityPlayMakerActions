using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public virtual void clear()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Algorithm), "owner")]
    public class Algorithm_clear : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] Algorithm")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Algorithm))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Algorithm))
            {
                LogError("owner is not initialized. Add Action \"newAlgorithm\".");
                return;
            }
            OpenCVForUnity.CoreModule.Algorithm wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Algorithm, OpenCVForUnity.CoreModule.Algorithm>(owner);

            wrapped_owner.clear();


        }

    }

}
