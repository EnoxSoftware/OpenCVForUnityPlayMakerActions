using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static void convexHull (MatOfPoint points, MatOfInt hull)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint), "points")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "hull")]
    public class Imgproc_convexHull_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint))]
        public HutongGames.PlayMaker.FsmObject points;

        [HutongGames.PlayMaker.ActionSection ("[arg2] MatOfInt")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmObject hull;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            points = null;
            hull = null;
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
            OpenCVForUnity.CoreModule.MatOfPoint wrapped_points = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint, OpenCVForUnity.CoreModule.MatOfPoint> (points);

            if (!(hull.Value is OpenCVForUnityPlayMakerActions.MatOfInt))
            {
                LogError ("hull is not initialized. Add Action \"newMatOfInt\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfInt wrapped_hull = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.CoreModule.MatOfInt> (hull);

            OpenCVForUnity.ImgprocModule.Imgproc.convexHull (wrapped_points, wrapped_hull);


        }

    }

}
