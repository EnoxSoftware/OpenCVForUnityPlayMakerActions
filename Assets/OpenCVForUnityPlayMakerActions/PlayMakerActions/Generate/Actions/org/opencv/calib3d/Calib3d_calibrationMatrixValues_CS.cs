using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_calib3d")]
    [HutongGames.PlayMaker.Tooltip ("public static void calibrationMatrixValues (Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double[] fovx, double[] fovy, double[] focalLength, Point principalPoint, double[] aspectRatio)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "cameraMatrix")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "imageSize_width")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "imageSize_height")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "apertureWidth")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "apertureHeight")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "fovx")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "fovy")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "focalLength")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "principalPoint_x")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "principalPoint_y")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "aspectRatio")]
    public class Calib3d_calibrationMatrixValues_CS : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject cameraMatrix;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Size")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat imageSize_width;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat imageSize_height;

        [HutongGames.PlayMaker.ActionSection ("[arg3] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat apertureWidth;

        [HutongGames.PlayMaker.ActionSection ("[arg4] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat apertureHeight;

        [HutongGames.PlayMaker.ActionSection ("[arg5] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray fovx;

        [HutongGames.PlayMaker.ActionSection ("[arg6] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray fovy;

        [HutongGames.PlayMaker.ActionSection ("[arg7] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray focalLength;

        [HutongGames.PlayMaker.ActionSection ("[arg8] Point")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat principalPoint_x;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat principalPoint_y;

        [HutongGames.PlayMaker.ActionSection ("[arg9] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray aspectRatio;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            cameraMatrix = null;
            imageSize_width = 0.0f;
            imageSize_height = 0.0f;
            apertureWidth = 0.0f;
            apertureHeight = 0.0f;
            fovx = null;
            fovy = null;
            focalLength = null;
            principalPoint_x = 0.0f;
            principalPoint_y = 0.0f;
            aspectRatio = null;
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

            if (!(cameraMatrix.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("cameraMatrix is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_cameraMatrix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (cameraMatrix);

            float[] float_fovx = fovx.floatValues;
            double[] casted_fovx = new double[float_fovx.Length];
            float_fovx.CopyTo (casted_fovx, 0);

            float[] float_fovy = fovy.floatValues;
            double[] casted_fovy = new double[float_fovy.Length];
            float_fovy.CopyTo (casted_fovy, 0);

            float[] float_focalLength = focalLength.floatValues;
            double[] casted_focalLength = new double[float_focalLength.Length];
            float_focalLength.CopyTo (casted_focalLength, 0);

            float[] float_aspectRatio = aspectRatio.floatValues;
            double[] casted_aspectRatio = new double[float_aspectRatio.Length];
            float_aspectRatio.CopyTo (casted_aspectRatio, 0);

            OpenCVForUnity.Calib3d.calibrationMatrixValues (wrapped_cameraMatrix, new OpenCVForUnity.Size ((double)imageSize_width.Value, (double)imageSize_height.Value), (float)apertureWidth.Value, (float)apertureHeight.Value, casted_fovx, casted_fovy, casted_focalLength, new OpenCVForUnity.Point ((double)principalPoint_x.Value, (double)principalPoint_y.Value), casted_aspectRatio);

            for (int i = 0; i < casted_fovx.Length; i++)
            {
                float_fovx[i] = (float)casted_fovx[i];
            }

            for (int i = 0; i < casted_fovy.Length; i++)
            {
                float_fovy[i] = (float)casted_fovy[i];
            }

            for (int i = 0; i < casted_focalLength.Length; i++)
            {
                float_focalLength[i] = (float)casted_focalLength[i];
            }

            for (int i = 0; i < casted_aspectRatio.Length; i++)
            {
                float_aspectRatio[i] = (float)casted_aspectRatio[i];
            }


        }

    }

}
