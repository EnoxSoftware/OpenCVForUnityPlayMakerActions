using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ml")]
    [HutongGames.PlayMaker.Tooltip ("public void setTermCriteria (TermCriteria val)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.LogisticRegression), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "val_type")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "val_maxCount")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "val_epsilon")]
    public class LogisticRegression_setTermCriteria_S : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] LogisticRegression")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.LogisticRegression))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] TermCriteria")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt val_type;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt val_maxCount;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat val_epsilon;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            val_type = 0;
            val_maxCount = 0;
            val_epsilon = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.LogisticRegression))
            {
                LogError ("owner is not initialized. Add Action \"newLogisticRegression\".");
                return;
            }
            OpenCVForUnity.LogisticRegression wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.LogisticRegression, OpenCVForUnity.LogisticRegression> (owner);

            wrapped_owner.setTermCriteria (new OpenCVForUnity.TermCriteria ((int)val_type.Value, (int)val_maxCount.Value, (double)val_epsilon.Value));


        }

    }

}
