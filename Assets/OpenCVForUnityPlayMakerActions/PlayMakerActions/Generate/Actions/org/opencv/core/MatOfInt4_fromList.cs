using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public void fromList (List<int> lb)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt4), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "lb")]
    public class MatOfInt4_fromList : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] MatOfInt4")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt4))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] List<int>(Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray lb;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            lb = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfInt4))
            {
                LogError ("owner is not initialized. Add Action \"newMatOfInt4\".");
                return;
            }
            OpenCVForUnity.MatOfInt4 wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt4, OpenCVForUnity.MatOfInt4> (owner);

            int[] int_lb = lb.intValues;
            List<int> wrapped_lb = new List<int> (int_lb);

            wrapped_owner.fromList (wrapped_lb);

            wrapped_lb.CopyTo (int_lb);


        }

    }

}
