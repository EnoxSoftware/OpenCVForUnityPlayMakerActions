using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public static Rect2d intersect (Rect2d a, Rect2d b)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect2d), "a")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect2d), "b")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect2d), "storeResult")]
    public class Rect2d_intersect : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Rect2d")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect2d))]
        public HutongGames.PlayMaker.FsmObject a;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Rect2d")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect2d))]
        public HutongGames.PlayMaker.FsmObject b;

        [HutongGames.PlayMaker.ActionSection ("[return] Rect2d")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect2d))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            a = null;
            b = null;
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

            if (!(a.Value is OpenCVForUnityPlayMakerActions.Rect2d))
            {
                LogError ("a is not initialized. Add Action \"newRect2d\".");
                return;
            }
            OpenCVForUnity.Rect2d wrapped_a = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect2d, OpenCVForUnity.Rect2d> (a);

            if (!(b.Value is OpenCVForUnityPlayMakerActions.Rect2d))
            {
                LogError ("b is not initialized. Add Action \"newRect2d\".");
                return;
            }
            OpenCVForUnity.Rect2d wrapped_b = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect2d, OpenCVForUnity.Rect2d> (b);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Rect2d)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Rect2d ();
            ((OpenCVForUnityPlayMakerActions.Rect2d)storeResult.Value).wrappedObject = OpenCVForUnity.Rect2d.intersect (wrapped_a, wrapped_b);


        }

    }

}
