using UnityEngine;

using OpenCVForUnity.UnityUtils.Helper;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public Mat GetDownScaleMat (Mat originalMat)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (ImageOptimizationHelper), "gameObject")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "storeResult")]
    public class OptimizationWebCamTextureToMatHelper_GetDownScaleMat : ImageOptimizationHelperComponentAction<ImageOptimizationHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent (typeof (ImageOptimizationHelper))]
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

			OpenCVForUnity.CoreModule.Mat wrapped_originalMat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (originalMat);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Mat))
                storeResult.Value = new OpenCVForUnityPlayMakerActions.Mat ();
            ((OpenCVForUnityPlayMakerActions.Mat)storeResult.Value).wrappedObject = imageOptimizationHelper.GetDownScaleMat (wrapped_originalMat);

        }
    }

}
