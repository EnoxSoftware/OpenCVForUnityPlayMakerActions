using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static FastGlobalSmootherFilter createFastGlobalSmootherFilter (Mat guide, double lambda, double sigma_color, double lambda_attenuation, int num_iter)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "guide")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "lambda")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_color")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "lambda_attenuation")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "num_iter")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.FastGlobalSmootherFilter), "storeResult")]
    public class Ximgproc_createFastGlobalSmootherFilter : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject guide;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject lambda;

        [HutongGames.PlayMaker.ActionSection ("[arg3] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_color;

        [HutongGames.PlayMaker.ActionSection ("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject lambda_attenuation;

        [HutongGames.PlayMaker.ActionSection ("[arg5] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt num_iter;

        [HutongGames.PlayMaker.ActionSection ("[return] FastGlobalSmootherFilter")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.FastGlobalSmootherFilter))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            guide = null;
            lambda = null;
            sigma_color = null;
            lambda_attenuation = null;
            num_iter = 0;
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

            if (!(guide.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("guide is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_guide = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (guide);

            if (!(lambda.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("lambda is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_lambda = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (lambda);

            if (!(sigma_color.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_color is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_color = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_color);

            if (!(lambda_attenuation.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("lambda_attenuation is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_lambda_attenuation = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (lambda_attenuation);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.FastGlobalSmootherFilter)) storeResult.Value = new OpenCVForUnityPlayMakerActions.FastGlobalSmootherFilter ();
            ((OpenCVForUnityPlayMakerActions.FastGlobalSmootherFilter)storeResult.Value).wrappedObject = OpenCVForUnity.Ximgproc.createFastGlobalSmootherFilter (wrapped_guide, wrapped_lambda, wrapped_sigma_color, wrapped_lambda_attenuation, num_iter.Value);


        }

    }

}
