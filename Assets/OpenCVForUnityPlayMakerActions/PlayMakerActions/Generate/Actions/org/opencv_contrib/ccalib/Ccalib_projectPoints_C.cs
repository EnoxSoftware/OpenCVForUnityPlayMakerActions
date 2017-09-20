using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ccalib")]
    [HutongGames.PlayMaker.Tooltip ("public static void projectPoints (MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat rvec, Mat tvec, Mat K, double xi, Mat D, Mat jacobian)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f), "objectPoints")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f), "imagePoints")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "rvec")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "tvec")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "K")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "xi")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "D")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "jacobian")]
    public class Ccalib_projectPoints_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint3f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f))]
        public HutongGames.PlayMaker.FsmObject objectPoints;

        [HutongGames.PlayMaker.ActionSection ("[arg2] MatOfPoint2f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmObject imagePoints;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject rvec;

        [HutongGames.PlayMaker.ActionSection ("[arg4] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject tvec;

        [HutongGames.PlayMaker.ActionSection ("[arg5] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject K;

        [HutongGames.PlayMaker.ActionSection ("[arg6] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat xi;

        [HutongGames.PlayMaker.ActionSection ("[arg7] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject D;

        [HutongGames.PlayMaker.ActionSection ("[arg8] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject jacobian;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            objectPoints = null;
            imagePoints = null;
            rvec = null;
            tvec = null;
            K = null;
            xi = 0.0f;
            D = null;
            jacobian = null;
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

            if (!(imagePoints.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f))
            {
                LogError ("imagePoints is not initialized. Add Action \"newMatOfPoint2f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint2f wrapped_imagePoints = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.MatOfPoint2f> (imagePoints);

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

            if (!(K.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("K is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_K = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (K);

            if (!(D.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("D is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_D = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (D);

            if (!(jacobian.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("jacobian is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_jacobian = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (jacobian);

            OpenCVForUnity.Ccalib.projectPoints (wrapped_objectPoints, wrapped_imagePoints, wrapped_rvec, wrapped_tvec, wrapped_K, (float)xi.Value, wrapped_D, wrapped_jacobian);


        }

    }

}
