using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public Scalar mul (Scalar it)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "it")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "storeResult")]
    public class Scalar_mul_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] Scalar")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Scalar")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject it;

        [HutongGames.PlayMaker.ActionSection ("[return] Scalar")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            it = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Scalar))
            {
                LogError ("owner is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.Scalar wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.Scalar> (owner);

            if (!(it.Value is OpenCVForUnityPlayMakerActions.Scalar))
            {
                LogError ("it is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.Scalar wrapped_it = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.Scalar> (it);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Scalar)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Scalar ();
            ((OpenCVForUnityPlayMakerActions.Scalar)storeResult.Value).wrappedObject = wrapped_owner.mul (wrapped_it);


        }

    }

}
