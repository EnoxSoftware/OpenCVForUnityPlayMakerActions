using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public static bool checkRange (Mat a, bool quiet, double minVal, double maxVal)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "a")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "quiet")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "minVal")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "maxVal")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "trueEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "falseEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "storeResult")]
    public class Core_checkRange : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject a;

        [HutongGames.PlayMaker.ActionSection ("[arg2] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool quiet;

        [HutongGames.PlayMaker.ActionSection ("[arg3] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject minVal;

        [HutongGames.PlayMaker.ActionSection ("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject maxVal;

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
            a = null;
            quiet = false;
            minVal = null;
            maxVal = null;
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

            if (!(a.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("a is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_a = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (a);

            if (!(minVal.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("minVal is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_minVal = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (minVal);

            if (!(maxVal.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("maxVal is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_maxVal = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (maxVal);

            storeResult.Value = OpenCVForUnity.Core.checkRange (wrapped_a, quiet.Value, wrapped_minVal, wrapped_maxVal);

            Fsm.Event (storeResult.Value ? trueEvent : falseEvent);

        }

    }

}
