using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_aruco")]
    [HutongGames.PlayMaker.Tooltip ("public static void detectCharucoDiamond (Mat image, List<Mat> markerCorners, Mat markerIds, float squareMarkerLengthRate, List<Mat> diamondCorners, Mat diamondIds)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "image")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "markerCorners")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "markerIds")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "squareMarkerLengthRate")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "diamondCorners")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "diamondIds")]
    public class Aruco_detectCharucoDiamond_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject image;

        [HutongGames.PlayMaker.ActionSection ("[arg2] List<Mat>(Array(Mat))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmArray markerCorners;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject markerIds;

        [HutongGames.PlayMaker.ActionSection ("[arg4] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat squareMarkerLengthRate;

        [HutongGames.PlayMaker.ActionSection ("[arg5] List<Mat>(Array(Mat))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmArray diamondCorners;

        [HutongGames.PlayMaker.ActionSection ("[arg6] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject diamondIds;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            image = null;
            markerCorners = null;
            markerIds = null;
            squareMarkerLengthRate = 0.0f;
            diamondCorners = null;
            diamondIds = null;
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

            if (!(image.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("image is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_image = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (image);

            List<OpenCVForUnity.Mat> wrapped_markerCorners = new List<OpenCVForUnity.Mat> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (markerCorners, wrapped_markerCorners);

            if (!(markerIds.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("markerIds is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_markerIds = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (markerIds);

            List<OpenCVForUnity.Mat> wrapped_diamondCorners = new List<OpenCVForUnity.Mat> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (diamondCorners, wrapped_diamondCorners);

            if (!(diamondIds.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("diamondIds is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_diamondIds = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (diamondIds);

            OpenCVForUnity.Aruco.detectCharucoDiamond (wrapped_image, wrapped_markerCorners, wrapped_markerIds, squareMarkerLengthRate.Value, wrapped_diamondCorners, wrapped_diamondIds);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.Mat, OpenCVForUnityPlayMakerActions.Mat> (wrapped_markerCorners, markerCorners);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.Mat, OpenCVForUnityPlayMakerActions.Mat> (wrapped_diamondCorners, diamondCorners);


        }

    }

}
