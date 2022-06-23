using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_xfeatures2d")]
    [HutongGames.PlayMaker.Tooltip("public void setScaleFactor(float scale_factor)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.BoostDesc), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "scale_factor")]
    public class BoostDesc_setScaleFactor : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] BoostDesc")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.BoostDesc))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat scale_factor;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            scale_factor = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.BoostDesc))
            {
                LogError("owner is not initialized. Add Action \"newBoostDesc\".");
                return;
            }
            OpenCVForUnity.Xfeatures2dModule.BoostDesc wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.BoostDesc, OpenCVForUnity.Xfeatures2dModule.BoostDesc>(owner);

            wrapped_owner.setScaleFactor(scale_factor.Value);


        }

    }

}
