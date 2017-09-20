using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public static Rect intersect (Rect a, Rect b)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "a")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "b")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "storeResult")]
    public class Rect_intersect : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject a;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject b;

        [HutongGames.PlayMaker.ActionSection ("[return] Rect")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
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

            if (!(a.Value is OpenCVForUnityPlayMakerActions.Rect))
            {
                LogError ("a is not initialized. Add Action \"newRect\".");
                return;
            }
            OpenCVForUnity.Rect wrapped_a = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect, OpenCVForUnity.Rect> (a);

            if (!(b.Value is OpenCVForUnityPlayMakerActions.Rect))
            {
                LogError ("b is not initialized. Add Action \"newRect\".");
                return;
            }
            OpenCVForUnity.Rect wrapped_b = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect, OpenCVForUnity.Rect> (b);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Rect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Rect ();
            ((OpenCVForUnityPlayMakerActions.Rect)storeResult.Value).wrappedObject = OpenCVForUnity.Rect.intersect (wrapped_a, wrapped_b);


        }

    }

}
