using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static double pointPolygonTest (MatOfPoint2f contour, Point pt, bool measureDist)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f), "contour")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Point), "pt")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "measureDist")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "storeResult")]
    public class Imgproc_pointPolygonTest : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint2f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmObject contour;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Point")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Point))]
        public HutongGames.PlayMaker.FsmObject pt;

        [HutongGames.PlayMaker.ActionSection ("[arg3] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool measureDist;

        [HutongGames.PlayMaker.ActionSection ("[return] double(Double)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            contour = null;
            pt = null;
            measureDist = false;
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

            if (!(contour.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f))
            {
                LogError ("contour is not initialized. Add Action \"newMatOfPoint2f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint2f wrapped_contour = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.MatOfPoint2f> (contour);

            if (!(pt.Value is OpenCVForUnityPlayMakerActions.Point))
            {
                LogError ("pt is not initialized. Add Action \"newPoint\".");
                return;
            }
            OpenCVForUnity.Point wrapped_pt = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Point, OpenCVForUnity.Point> (pt);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Double)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Double ();
            ((OpenCVForUnityPlayMakerActions.Double)storeResult.Value).wrappedObject = OpenCVForUnity.Imgproc.pointPolygonTest (wrapped_contour, wrapped_pt, measureDist.Value);


        }

    }

}
