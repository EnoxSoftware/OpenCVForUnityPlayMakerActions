using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_saliency")]
    [HutongGames.PlayMaker.Tooltip ("public bool init ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "trueEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "falseEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "storeResult")]
    public class MotionSaliencyBinWangApr2014_init : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] MotionSaliencyBinWangApr2014")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[return] bool")]
        [HutongGames.PlayMaker.Tooltip ("Event to send if result is true.")]
        public HutongGames.PlayMaker.FsmEvent trueEvent;

        [HutongGames.PlayMaker.Tooltip ("Event to send if result is false.")]
        public HutongGames.PlayMaker.FsmEvent falseEvent;

        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            trueEvent = null;
            falseEvent = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014))
            {
                LogError ("owner is not initialized. Add Action \"newMotionSaliencyBinWangApr2014\".");
                return;
            }
            OpenCVForUnity.MotionSaliencyBinWangApr2014 wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014, OpenCVForUnity.MotionSaliencyBinWangApr2014> (owner);

            storeResult.Value = wrapped_owner.init ();

            Fsm.Event (storeResult.Value ? trueEvent : falseEvent);

        }

    }

}
