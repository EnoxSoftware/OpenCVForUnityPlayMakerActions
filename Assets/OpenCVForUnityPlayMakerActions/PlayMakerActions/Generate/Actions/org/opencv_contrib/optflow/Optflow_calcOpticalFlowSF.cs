using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.OptflowModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_optflow")]
    [HutongGames.PlayMaker.Tooltip ("public static void calcOpticalFlowSF (Mat from, Mat to, Mat flow, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "from")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "to")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "flow")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "layers")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "averaging_block_size")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "max_flow")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_dist")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_color")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "postprocess_window")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_dist_fix")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_color_fix")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "occ_thr")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "upscale_averaging_radius")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "upscale_sigma_dist")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "upscale_sigma_color")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "speed_up_thr")]
    public class Optflow_calcOpticalFlowSF : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject from;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject to;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject flow;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt layers;

        [HutongGames.PlayMaker.ActionSection ("[arg5] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt averaging_block_size;

        [HutongGames.PlayMaker.ActionSection ("[arg6] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt max_flow;

        [HutongGames.PlayMaker.ActionSection ("[arg7] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_dist;

        [HutongGames.PlayMaker.ActionSection ("[arg8] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_color;

        [HutongGames.PlayMaker.ActionSection ("[arg9] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt postprocess_window;

        [HutongGames.PlayMaker.ActionSection ("[arg10] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_dist_fix;

        [HutongGames.PlayMaker.ActionSection ("[arg11] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_color_fix;

        [HutongGames.PlayMaker.ActionSection ("[arg12] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject occ_thr;

        [HutongGames.PlayMaker.ActionSection ("[arg13] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt upscale_averaging_radius;

        [HutongGames.PlayMaker.ActionSection ("[arg14] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject upscale_sigma_dist;

        [HutongGames.PlayMaker.ActionSection ("[arg15] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject upscale_sigma_color;

        [HutongGames.PlayMaker.ActionSection ("[arg16] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject speed_up_thr;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            from = null;
            to = null;
            flow = null;
            layers = 0;
            averaging_block_size = 0;
            max_flow = 0;
            sigma_dist = null;
            sigma_color = null;
            postprocess_window = 0;
            sigma_dist_fix = null;
            sigma_color_fix = null;
            occ_thr = null;
            upscale_averaging_radius = 0;
            upscale_sigma_dist = null;
            upscale_sigma_color = null;
            speed_up_thr = null;
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

            if (!(from.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("from is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_from = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (from);

            if (!(to.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("to is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_to = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (to);

            if (!(flow.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("flow is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_flow = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (flow);

            if (!(sigma_dist.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_dist is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_dist = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_dist);

            if (!(sigma_color.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_color is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_color = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_color);

            if (!(sigma_dist_fix.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_dist_fix is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_dist_fix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_dist_fix);

            if (!(sigma_color_fix.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_color_fix is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_color_fix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_color_fix);

            if (!(occ_thr.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("occ_thr is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_occ_thr = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (occ_thr);

            if (!(upscale_sigma_dist.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("upscale_sigma_dist is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_upscale_sigma_dist = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (upscale_sigma_dist);

            if (!(upscale_sigma_color.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("upscale_sigma_color is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_upscale_sigma_color = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (upscale_sigma_color);

            if (!(speed_up_thr.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("speed_up_thr is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_speed_up_thr = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (speed_up_thr);

            OpenCVForUnity.OptflowModule.Optflow.calcOpticalFlowSF (wrapped_from, wrapped_to, wrapped_flow, layers.Value, averaging_block_size.Value, max_flow.Value, wrapped_sigma_dist, wrapped_sigma_color, postprocess_window.Value, wrapped_sigma_dist_fix, wrapped_sigma_color_fix, wrapped_occ_thr, upscale_averaging_radius.Value, wrapped_upscale_sigma_dist, wrapped_upscale_sigma_color, wrapped_speed_up_thr);


        }

    }

}
