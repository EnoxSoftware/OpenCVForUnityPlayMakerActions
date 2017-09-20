using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static RotatedRect minAreaRect (MatOfPoint2f points)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f), "points")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.RotatedRect), "storeResult")]
    public class Imgproc_minAreaRect : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint2f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmObject points;

        [HutongGames.PlayMaker.ActionSection ("[return] RotatedRect")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.RotatedRect))]
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

            if (!(points.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f))
            {
                LogError ("points is not initialized. Add Action \"newMatOfPoint2f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint2f wrapped_points = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.MatOfPoint2f> (points);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.RotatedRect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.RotatedRect ();
            ((OpenCVForUnityPlayMakerActions.RotatedRect)storeResult.Value).wrappedObject = OpenCVForUnity.Imgproc.minAreaRect (wrapped_points);


        }

    }

}
