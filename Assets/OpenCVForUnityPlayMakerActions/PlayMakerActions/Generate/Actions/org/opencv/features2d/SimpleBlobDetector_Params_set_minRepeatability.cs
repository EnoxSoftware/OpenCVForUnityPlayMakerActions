using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip("public void set_minRepeatability(long minRepeatability)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Long), "minRepeatability")]
    public class SimpleBlobDetector_Params_set_minRepeatability : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] SimpleBlobDetector_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] long(Long)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Long))]
        public HutongGames.PlayMaker.FsmObject minRepeatability;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            minRepeatability = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params))
            {
                LogError("owner is not initialized. Add Action \"newSimpleBlobDetector_Params\".");
                return;
            }
            OpenCVForUnity.Features2dModule.SimpleBlobDetector_Params wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SimpleBlobDetector_Params, OpenCVForUnity.Features2dModule.SimpleBlobDetector_Params>(owner);

            if (!(minRepeatability.Value is OpenCVForUnityPlayMakerActions.Long))
            {
                LogError("minRepeatability is not initialized. Add Action \"newLong\".");
                return;
            }
            System.Int64 wrapped_minRepeatability = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Long, System.Int64>(minRepeatability);

            wrapped_owner.set_minRepeatability(wrapped_minRepeatability);


        }

    }

}
