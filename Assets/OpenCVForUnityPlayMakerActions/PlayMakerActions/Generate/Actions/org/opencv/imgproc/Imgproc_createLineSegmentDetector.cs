using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public static LineSegmentDetector createLineSegmentDetector(int _refine, double _scale, double _sigma_scale, double _quant, double _ang_th, double _log_eps, double _density_th, int _n_bins)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "_refine")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_scale")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_sigma_scale")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_quant")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_ang_th")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_log_eps")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_density_th")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "_n_bins")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.LineSegmentDetector), "storeResult")]
    public class Imgproc_createLineSegmentDetector : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _refine;

        [HutongGames.PlayMaker.ActionSection("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _scale;

        [HutongGames.PlayMaker.ActionSection("[arg3] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _sigma_scale;

        [HutongGames.PlayMaker.ActionSection("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _quant;

        [HutongGames.PlayMaker.ActionSection("[arg5] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _ang_th;

        [HutongGames.PlayMaker.ActionSection("[arg6] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _log_eps;

        [HutongGames.PlayMaker.ActionSection("[arg7] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _density_th;

        [HutongGames.PlayMaker.ActionSection("[arg8] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _n_bins;

        [HutongGames.PlayMaker.ActionSection("[return] LineSegmentDetector")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.LineSegmentDetector))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            _refine = 0;
            _scale = null;
            _sigma_scale = null;
            _quant = null;
            _ang_th = null;
            _log_eps = null;
            _density_th = null;
            _n_bins = 0;
            storeResult = null;
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

            if (!(_scale.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_scale is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__scale = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_scale);

            if (!(_sigma_scale.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_sigma_scale is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__sigma_scale = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_sigma_scale);

            if (!(_quant.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_quant is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__quant = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_quant);

            if (!(_ang_th.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_ang_th is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__ang_th = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_ang_th);

            if (!(_log_eps.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_log_eps is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__log_eps = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_log_eps);

            if (!(_density_th.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_density_th is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__density_th = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_density_th);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.LineSegmentDetector)) storeResult.Value = new OpenCVForUnityPlayMakerActions.LineSegmentDetector();
            ((OpenCVForUnityPlayMakerActions.LineSegmentDetector)storeResult.Value).wrappedObject = OpenCVForUnity.ImgprocModule.Imgproc.createLineSegmentDetector(_refine.Value, wrapped__scale, wrapped__sigma_scale, wrapped__quant, wrapped__ang_th, wrapped__log_eps, wrapped__density_th, _n_bins.Value);


        }

    }

}
