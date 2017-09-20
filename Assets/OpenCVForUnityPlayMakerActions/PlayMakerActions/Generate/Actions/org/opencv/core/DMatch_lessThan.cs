using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public bool lessThan (DMatch it)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DMatch), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DMatch), "it")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "trueEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "falseEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "storeResult")]
    public class DMatch_lessThan : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] DMatch")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DMatch))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] DMatch")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DMatch))]
        public HutongGames.PlayMaker.FsmObject it;

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
            it = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.DMatch))
            {
                LogError ("owner is not initialized. Add Action \"newDMatch\".");
                return;
            }
            OpenCVForUnity.DMatch wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.DMatch, OpenCVForUnity.DMatch> (owner);

            if (!(it.Value is OpenCVForUnityPlayMakerActions.DMatch))
            {
                LogError ("it is not initialized. Add Action \"newDMatch\".");
                return;
            }
            OpenCVForUnity.DMatch wrapped_it = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.DMatch, OpenCVForUnity.DMatch> (it);

            storeResult.Value = wrapped_owner.lessThan (wrapped_it);

            Fsm.Event (storeResult.Value ? trueEvent : falseEvent);

        }

    }

}
