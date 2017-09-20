using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public Rect (Point p1, Point p2)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Point), "p1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Point), "p2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "storeResult")]
    public class Rect_newRect_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Point")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Point))]
        public HutongGames.PlayMaker.FsmObject p1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Point")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Point))]
        public HutongGames.PlayMaker.FsmObject p2;

        [HutongGames.PlayMaker.ActionSection ("[return] Rect")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            p1 = null;
            p2 = null;
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

            if (!(p1.Value is OpenCVForUnityPlayMakerActions.Point))
            {
                LogError ("p1 is not initialized. Add Action \"newPoint\".");
                return;
            }
            OpenCVForUnity.Point wrapped_p1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Point, OpenCVForUnity.Point> (p1);

            if (!(p2.Value is OpenCVForUnityPlayMakerActions.Point))
            {
                LogError ("p2 is not initialized. Add Action \"newPoint\".");
                return;
            }
            OpenCVForUnity.Point wrapped_p2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Point, OpenCVForUnity.Point> (p2);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Rect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Rect ();
            ((OpenCVForUnityPlayMakerActions.Rect)storeResult.Value).wrappedObject = new OpenCVForUnity.Rect (wrapped_p1, wrapped_p2);


        }

    }

}
