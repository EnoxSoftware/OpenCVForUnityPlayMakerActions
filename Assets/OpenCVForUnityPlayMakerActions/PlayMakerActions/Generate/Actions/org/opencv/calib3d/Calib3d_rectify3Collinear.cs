using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_calib3d")]
    [HutongGames.PlayMaker.Tooltip ("public static float rectify3Collinear (Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, List<Mat> imgpt1, List<Mat> imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat R1, Mat R2, Mat R3, Mat P1, Mat P2, Mat P3, Mat Q, double alpha, Size newImgSize, Rect roi1, Rect roi2, int flags)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "distCoeffs1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "distCoeffs2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "distCoeffs3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "imgpt1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "imgpt3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "imageSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "R12")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "T12")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "R13")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "T13")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "R1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "R2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "R3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "P1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "P2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "P3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "Q")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "alpha")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "newImgSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "roi1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect), "roi2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "flags")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "storeResult")]
    public class Calib3d_rectify3Collinear : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject distCoeffs1;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix2;

        [HutongGames.PlayMaker.ActionSection ("[arg4] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject distCoeffs2;

        [HutongGames.PlayMaker.ActionSection ("[arg5] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix3;

        [HutongGames.PlayMaker.ActionSection ("[arg6] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject distCoeffs3;

        [HutongGames.PlayMaker.ActionSection ("[arg7] List<Mat>(Array(Mat))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmArray imgpt1;

        [HutongGames.PlayMaker.ActionSection ("[arg8] List<Mat>(Array(Mat))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmArray imgpt3;

        [HutongGames.PlayMaker.ActionSection ("[arg9] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject imageSize;

        [HutongGames.PlayMaker.ActionSection ("[arg10] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject R12;

        [HutongGames.PlayMaker.ActionSection ("[arg11] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject T12;

        [HutongGames.PlayMaker.ActionSection ("[arg12] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject R13;

        [HutongGames.PlayMaker.ActionSection ("[arg13] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject T13;

        [HutongGames.PlayMaker.ActionSection ("[arg14] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject R1;

        [HutongGames.PlayMaker.ActionSection ("[arg15] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject R2;

        [HutongGames.PlayMaker.ActionSection ("[arg16] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject R3;

        [HutongGames.PlayMaker.ActionSection ("[arg17] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject P1;

        [HutongGames.PlayMaker.ActionSection ("[arg18] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject P2;

        [HutongGames.PlayMaker.ActionSection ("[arg19] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject P3;

        [HutongGames.PlayMaker.ActionSection ("[arg20] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject Q;

        [HutongGames.PlayMaker.ActionSection ("[arg21] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject alpha;

        [HutongGames.PlayMaker.ActionSection ("[arg22] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject newImgSize;

        [HutongGames.PlayMaker.ActionSection ("[arg23] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject roi1;

        [HutongGames.PlayMaker.ActionSection ("[arg24] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject roi2;

        [HutongGames.PlayMaker.ActionSection ("[arg25] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt flags;

        [HutongGames.PlayMaker.ActionSection ("[return] float")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            cameraMatrix1 = null;
            distCoeffs1 = null;
            cameraMatrix2 = null;
            distCoeffs2 = null;
            cameraMatrix3 = null;
            distCoeffs3 = null;
            imgpt1 = null;
            imgpt3 = null;
            imageSize = null;
            R12 = null;
            T12 = null;
            R13 = null;
            T13 = null;
            R1 = null;
            R2 = null;
            R3 = null;
            P1 = null;
            P2 = null;
            P3 = null;
            Q = null;
            alpha = null;
            newImgSize = null;
            roi1 = null;
            roi2 = null;
            flags = 0;
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

            if (!(cameraMatrix1.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("cameraMatrix1 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_cameraMatrix1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (cameraMatrix1);

            if (!(distCoeffs1.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("distCoeffs1 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_distCoeffs1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (distCoeffs1);

            if (!(cameraMatrix2.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("cameraMatrix2 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_cameraMatrix2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (cameraMatrix2);

            if (!(distCoeffs2.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("distCoeffs2 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_distCoeffs2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (distCoeffs2);

            if (!(cameraMatrix3.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("cameraMatrix3 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_cameraMatrix3 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (cameraMatrix3);

            if (!(distCoeffs3.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("distCoeffs3 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_distCoeffs3 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (distCoeffs3);

            List<OpenCVForUnity.Mat> wrapped_imgpt1 = new List<OpenCVForUnity.Mat> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (imgpt1, wrapped_imgpt1);

            List<OpenCVForUnity.Mat> wrapped_imgpt3 = new List<OpenCVForUnity.Mat> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (imgpt3, wrapped_imgpt3);

            if (!(imageSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("imageSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.Size wrapped_imageSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.Size> (imageSize);

            if (!(R12.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("R12 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_R12 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (R12);

            if (!(T12.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("T12 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_T12 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (T12);

            if (!(R13.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("R13 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_R13 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (R13);

            if (!(T13.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("T13 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_T13 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (T13);

            if (!(R1.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("R1 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_R1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (R1);

            if (!(R2.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("R2 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_R2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (R2);

            if (!(R3.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("R3 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_R3 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (R3);

            if (!(P1.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("P1 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_P1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (P1);

            if (!(P2.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("P2 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_P2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (P2);

            if (!(P3.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("P3 is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_P3 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (P3);

            if (!(Q.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("Q is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_Q = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (Q);

            if (!(alpha.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("alpha is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_alpha = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (alpha);

            if (!(newImgSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("newImgSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.Size wrapped_newImgSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.Size> (newImgSize);

            if (!(roi1.Value is OpenCVForUnityPlayMakerActions.Rect))
            {
                LogError ("roi1 is not initialized. Add Action \"newRect\".");
                return;
            }
            OpenCVForUnity.Rect wrapped_roi1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect, OpenCVForUnity.Rect> (roi1);

            if (!(roi2.Value is OpenCVForUnityPlayMakerActions.Rect))
            {
                LogError ("roi2 is not initialized. Add Action \"newRect\".");
                return;
            }
            OpenCVForUnity.Rect wrapped_roi2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect, OpenCVForUnity.Rect> (roi2);

            storeResult.Value = OpenCVForUnity.Calib3d.rectify3Collinear (wrapped_cameraMatrix1, wrapped_distCoeffs1, wrapped_cameraMatrix2, wrapped_distCoeffs2, wrapped_cameraMatrix3, wrapped_distCoeffs3, wrapped_imgpt1, wrapped_imgpt3, wrapped_imageSize, wrapped_R12, wrapped_T12, wrapped_R13, wrapped_T13, wrapped_R1, wrapped_R2, wrapped_R3, wrapped_P1, wrapped_P2, wrapped_P3, wrapped_Q, wrapped_alpha, wrapped_newImgSize, wrapped_roi1, wrapped_roi2, flags.Value);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.Mat, OpenCVForUnityPlayMakerActions.Mat> (wrapped_imgpt1, imgpt1);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.Mat, OpenCVForUnityPlayMakerActions.Mat> (wrapped_imgpt3, imgpt3);


        }

    }

}
