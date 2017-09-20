using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip ("public static void drawMatchesKnn (Mat img1, MatOfKeyPoint keypoints1, Mat img2, MatOfKeyPoint keypoints2, List<MatOfDMatch> matches1to2, Mat outImg, Scalar matchColor, Scalar singlePointColor, List<MatOfByte> matchesMask, int flags)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "img1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "keypoints1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "img2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "keypoints2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "matches1to2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "outImg")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "matchColor")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "singlePointColor")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "matchesMask")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "flags")]
    public class Features2d_drawMatchesKnn : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject img1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] MatOfKeyPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint))]
        public HutongGames.PlayMaker.FsmObject keypoints1;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject img2;

        [HutongGames.PlayMaker.ActionSection ("[arg4] MatOfKeyPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint))]
        public HutongGames.PlayMaker.FsmObject keypoints2;

        [HutongGames.PlayMaker.ActionSection ("[arg5] List<MatOfDMatch>(Array(MatOfDMatch))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch))]
        public HutongGames.PlayMaker.FsmArray matches1to2;

        [HutongGames.PlayMaker.ActionSection ("[arg6] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject outImg;

        [HutongGames.PlayMaker.ActionSection ("[arg7] Scalar")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject matchColor;

        [HutongGames.PlayMaker.ActionSection ("[arg8] Scalar")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject singlePointColor;

        [HutongGames.PlayMaker.ActionSection ("[arg9] List<MatOfByte>(Array(MatOfByte))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfByte))]
        public HutongGames.PlayMaker.FsmArray matchesMask;

        [HutongGames.PlayMaker.ActionSection ("[arg10] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt flags;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            img1 = null;
            keypoints1 = null;
            img2 = null;
            keypoints2 = null;
            matches1to2 = null;
            outImg = null;
            matchColor = null;
            singlePointColor = null;
            matchesMask = null;
            flags = 0;
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

            if (!(img1.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("img1 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_img1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (img1);

            if (!(keypoints1.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("keypoints1 is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.MatOfKeyPoint wrapped_keypoints1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.MatOfKeyPoint> (keypoints1);

            if (!(img2.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("img2 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_img2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (img2);

            if (!(keypoints2.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("keypoints2 is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.MatOfKeyPoint wrapped_keypoints2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.MatOfKeyPoint> (keypoints2);

            List<OpenCVForUnity.MatOfDMatch> wrapped_matches1to2 = new List<OpenCVForUnity.MatOfDMatch> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfDMatch, OpenCVForUnity.MatOfDMatch> (matches1to2, wrapped_matches1to2);

            if (!(outImg.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("outImg is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_outImg = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (outImg);

            if (!(matchColor.Value is OpenCVForUnityPlayMakerActions.Scalar))
            {
                LogError ("matchColor is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.Scalar wrapped_matchColor = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.Scalar> (matchColor);

            if (!(singlePointColor.Value is OpenCVForUnityPlayMakerActions.Scalar))
            {
                LogError ("singlePointColor is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.Scalar wrapped_singlePointColor = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.Scalar> (singlePointColor);

            List<OpenCVForUnity.MatOfByte> wrapped_matchesMask = new List<OpenCVForUnity.MatOfByte> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfByte, OpenCVForUnity.MatOfByte> (matchesMask, wrapped_matchesMask);

            OpenCVForUnity.Features2d.drawMatchesKnn (wrapped_img1, wrapped_keypoints1, wrapped_img2, wrapped_keypoints2, wrapped_matches1to2, wrapped_outImg, wrapped_matchColor, wrapped_singlePointColor, wrapped_matchesMask, flags.Value);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfDMatch, OpenCVForUnityPlayMakerActions.MatOfDMatch> (wrapped_matches1to2, matches1to2);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfByte, OpenCVForUnityPlayMakerActions.MatOfByte> (wrapped_matchesMask, matchesMask);


        }

    }

}
