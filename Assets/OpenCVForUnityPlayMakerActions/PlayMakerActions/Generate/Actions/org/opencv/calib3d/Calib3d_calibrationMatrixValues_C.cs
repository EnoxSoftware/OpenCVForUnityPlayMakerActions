using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Calib3dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_calib3d")]
    [HutongGames.PlayMaker.Tooltip("public static void calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double[] fovx, double[] fovy, double[] focalLength, Point principalPoint, double[] aspectRatio)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Size), "imageSize")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "apertureWidth")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "apertureHeight")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "fovx")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "fovy")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "focalLength")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Point), "principalPoint")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "aspectRatio")]
    public class Calib3d_calibrationMatrixValues_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix;

        [HutongGames.PlayMaker.ActionSection("[arg2] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject imageSize;

        [HutongGames.PlayMaker.ActionSection("[arg3] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat apertureWidth;

        [HutongGames.PlayMaker.ActionSection("[arg4] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat apertureHeight;

        [HutongGames.PlayMaker.ActionSection("[arg5] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray fovx;

        [HutongGames.PlayMaker.ActionSection("[arg6] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray fovy;

        [HutongGames.PlayMaker.ActionSection("[arg7] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray focalLength;

        [HutongGames.PlayMaker.ActionSection("[arg8] Point")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Point))]
        public HutongGames.PlayMaker.FsmObject principalPoint;

        [HutongGames.PlayMaker.ActionSection("[arg9] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray aspectRatio;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            cameraMatrix = null;
            imageSize = null;
            apertureWidth = 0.0f;
            apertureHeight = 0.0f;
            fovx = null;
            fovy = null;
            focalLength = null;
            principalPoint = null;
            aspectRatio = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoProcess();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoProcess();
        }

        void DoProcess()
        {

            if (!(cameraMatrix.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("cameraMatrix is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_cameraMatrix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(cameraMatrix);

            if (!(imageSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError("imageSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped_imageSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size>(imageSize);

            float[] float_fovx = fovx.floatValues;
            double[] casted_fovx = new double[float_fovx.Length];
            float_fovx.CopyTo(casted_fovx, 0);

            float[] float_fovy = fovy.floatValues;
            double[] casted_fovy = new double[float_fovy.Length];
            float_fovy.CopyTo(casted_fovy, 0);

            float[] float_focalLength = focalLength.floatValues;
            double[] casted_focalLength = new double[float_focalLength.Length];
            float_focalLength.CopyTo(casted_focalLength, 0);

            if (!(principalPoint.Value is OpenCVForUnityPlayMakerActions.Point))
            {
                LogError("principalPoint is not initialized. Add Action \"newPoint\".");
                return;
            }
            OpenCVForUnity.CoreModule.Point wrapped_principalPoint = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Point, OpenCVForUnity.CoreModule.Point>(principalPoint);

            float[] float_aspectRatio = aspectRatio.floatValues;
            double[] casted_aspectRatio = new double[float_aspectRatio.Length];
            float_aspectRatio.CopyTo(casted_aspectRatio, 0);

            OpenCVForUnity.Calib3dModule.Calib3d.calibrationMatrixValues(wrapped_cameraMatrix, wrapped_imageSize, (float)apertureWidth.Value, (float)apertureHeight.Value, casted_fovx, casted_fovy, casted_focalLength, wrapped_principalPoint, casted_aspectRatio);

            for (int i = 0; i < casted_fovx.Length; i++)
            {
                fovx.Set(i, (float)casted_fovx[i]);
            }
            fovx.SaveChanges();

            for (int i = 0; i < casted_fovy.Length; i++)
            {
                fovy.Set(i, (float)casted_fovy[i]);
            }
            fovy.SaveChanges();

            for (int i = 0; i < casted_focalLength.Length; i++)
            {
                focalLength.Set(i, (float)casted_focalLength[i]);
            }
            focalLength.SaveChanges();

            for (int i = 0; i < casted_aspectRatio.Length; i++)
            {
                aspectRatio.Set(i, (float)casted_aspectRatio[i]);
            }
            aspectRatio.SaveChanges();


        }

    }

}
