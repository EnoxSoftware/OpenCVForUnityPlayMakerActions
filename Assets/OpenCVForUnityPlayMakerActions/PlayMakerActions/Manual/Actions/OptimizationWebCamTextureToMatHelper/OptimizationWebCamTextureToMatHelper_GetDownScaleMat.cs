using UnityEngine;

using OpenCVForUnityExample;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public Mat GetDownScaleMat (Mat originalMat)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OptimizationWebCamTextureToMatHelper), "gameObject")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "storeResult")]
    public class OptimizationWebCamTextureToMatHelper_GetDownScaleMat : OptimizationWebCamTextureToHelperComponentAction<OptimizationWebCamTextureToMatHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent (typeof (OptimizationWebCamTextureToMatHelper))]
        [Tooltip ("The GameObject to check.")]
        public HutongGames.PlayMaker.FsmOwnerDefault
            gameObject;
        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            originalMat;
        [HutongGames.PlayMaker.ActionSection ("[return] Mat")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            storeResult;
        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            gameObject = null;
            originalMat = null;
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
            var go = Fsm.GetOwnerDefaultTarget (gameObject);

            if (!UpdateCache (go))
            {
                return;
            }

            OpenCVForUnity.Mat wrapped_originalMat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (originalMat);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Mat))
                storeResult.Value = new OpenCVForUnityPlayMakerActions.Mat ();
            ((OpenCVForUnityPlayMakerActions.Mat)storeResult.Value).wrappedObject = optimizationWebCamTextureToMatHelper.GetDownScaleMat (wrapped_originalMat);

        }
    }

}
