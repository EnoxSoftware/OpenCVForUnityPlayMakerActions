using UnityEngine;

using OpenCVForUnityExample;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public virtual void Initialize ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OptimizationWebCamTextureToMatHelper), "gameObject")]
    public class OptimizationWebCamTextureToMatHelper_Initialize : OptimizationWebCamTextureToHelperComponentAction<OptimizationWebCamTextureToMatHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent (typeof (OptimizationWebCamTextureToMatHelper))]
        [Tooltip ("The GameObject to check.")]
        public HutongGames.PlayMaker.FsmOwnerDefault
            gameObject;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;


        public override void Reset ()
        {
            gameObject = null;
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

            optimizationWebCamTextureToMatHelper.Initialize ();

        }
    }

}
