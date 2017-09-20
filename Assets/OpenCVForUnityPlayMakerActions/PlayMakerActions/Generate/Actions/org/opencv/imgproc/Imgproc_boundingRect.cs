using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static Rect boundingRect (MatOfPoint points)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint), "points")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "storeResult")]
    public class Imgproc_boundingRect : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint))]
        public HutongGames.PlayMaker.FsmObject points;

        [HutongGames.PlayMaker.ActionSection ("[return] Rect")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            points = null;
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

            if (!(points.Value is OpenCVForUnityPlayMakerActions.MatOfPoint))
            {
                LogError ("points is not initialized. Add Action \"newMatOfPoint\".");
                return;
            }
            OpenCVForUnity.MatOfPoint wrapped_points = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint, OpenCVForUnity.MatOfPoint> (points);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Rect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Rect ();
            ((OpenCVForUnityPlayMakerActions.Rect)storeResult.Value).wrappedObject = OpenCVForUnity.Imgproc.boundingRect (wrapped_points);


        }

    }

}
