using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public void fromArray (params Rect2d[] a)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfRect2d), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "a")]
    public class MatOfRect2d_fromArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] MatOfRect2d")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfRect2d))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Rect2d[](Array(Rect2d))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Rect2d))]
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfRect2d))
            {
                LogError ("owner is not initialized. Add Action \"newMatOfRect2d\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfRect2d wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfRect2d, OpenCVForUnity.CoreModule.MatOfRect2d> (owner);

            OpenCVForUnity.CoreModule.Rect2d[] wrapped_a = new OpenCVForUnity.CoreModule.Rect2d[a.Length];
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToArray<OpenCVForUnityPlayMakerActions.Rect2d, OpenCVForUnity.CoreModule.Rect2d> (a, wrapped_a);

            wrapped_owner.fromArray (wrapped_a);

            OpenCVForUnityPlayMakerActionsUtils.ConvertArrayToFsmArray<OpenCVForUnity.CoreModule.Rect2d, OpenCVForUnityPlayMakerActions.Rect2d> (wrapped_a, a);


        }

    }

}
