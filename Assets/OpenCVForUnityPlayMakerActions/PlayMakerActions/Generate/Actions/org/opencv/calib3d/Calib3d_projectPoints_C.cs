using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_calib3d")]
    [HutongGames.PlayMaker.Tooltip ("public static void projectPoints (MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints, Mat jacobian, double aspectRatio)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f), "objectPoints")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "rvec")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "tvec")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDouble), "distCoeffs")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f), "imagePoints")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "jacobian")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "aspectRatio")]
    public class Calib3d_projectPoints_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint3f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f))]
        public HutongGames.PlayMaker.FsmObject objectPoints;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject rvec;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject tvec;

        [HutongGames.PlayMaker.ActionSection ("[arg4] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix;

        [HutongGames.PlayMaker.ActionSection ("[arg5] MatOfDouble")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDouble))]
        public HutongGames.PlayMaker.FsmObject distCoeffs;

        [HutongGames.PlayMaker.ActionSection ("[arg6] MatOfPoint2f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmObject imagePoints;

        [HutongGames.PlayMaker.ActionSection ("[arg7] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject jacobian;

        [HutongGames.PlayMaker.ActionSection ("[arg8] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat aspectRatio;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            objectPoints = null;
            rvec = null;
            tvec = null;
            cameraMatrix = null;
            distCoeffs = null;
            imagePoints = null;
            jacobian = null;
            aspectRatio = 0.0f;
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

            if (!(objectPoints.Value is OpenCVForUnityPlayMakerActions.MatOfPoint3f))
            {
                LogError ("objectPoints is not initialized. Add Action \"newMatOfPoint3f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint3f wrapped_objectPoints = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint3f, OpenCVForUnity.MatOfPoint3f> (objectPoints);

            if (!(rvec.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("rvec is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_rvec = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (rvec);

            if (!(tvec.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("tvec is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_tvec = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (tvec);

            if (!(cameraMatrix.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("cameraMatrix is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_cameraMatrix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (cameraMatrix);

            if (!(distCoeffs.Value is OpenCVForUnityPlayMakerActions.MatOfDouble))
            {
                LogError ("distCoeffs is not initialized. Add Action \"newMatOfDouble\".");
                return;
            }
            OpenCVForUnity.MatOfDouble wrapped_distCoeffs = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDouble, OpenCVForUnity.MatOfDouble> (distCoeffs);

            if (!(imagePoints.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f))
            {
                LogError ("imagePoints is not initialized. Add Action \"newMatOfPoint2f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint2f wrapped_imagePoints = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.MatOfPoint2f> (imagePoints);

            if (!(jacobian.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("jacobian is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_jacobian = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (jacobian);

            OpenCVForUnity.Calib3d.projectPoints (wrapped_objectPoints, wrapped_rvec, wrapped_tvec, wrapped_cameraMatrix, wrapped_distCoeffs, wrapped_imagePoints, wrapped_jacobian, (float)aspectRatio.Value);


        }

    }

}
