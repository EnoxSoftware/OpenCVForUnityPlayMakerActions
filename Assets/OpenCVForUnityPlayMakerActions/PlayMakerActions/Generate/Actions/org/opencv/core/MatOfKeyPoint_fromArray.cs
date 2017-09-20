using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public void fromArray (params KeyPoint[] a)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "a")]
    public class MatOfKeyPoint_fromArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] MatOfKeyPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] KeyPoint[](Array(KeyPoint))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.KeyPoint))]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            a = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("owner is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.MatOfKeyPoint wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.MatOfKeyPoint> (owner);

            OpenCVForUnity.KeyPoint[] wrapped_a = new OpenCVForUnity.KeyPoint[a.Length];
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToArray<OpenCVForUnityPlayMakerActions.KeyPoint, OpenCVForUnity.KeyPoint> (a, wrapped_a);

            wrapped_owner.fromArray (wrapped_a);

            OpenCVForUnityPlayMakerActionsUtils.ConvertArrayToFsmArray<OpenCVForUnity.KeyPoint, OpenCVForUnityPlayMakerActions.KeyPoint> (wrapped_a, a);


        }

    }

}
