using UnityEngine;

using OpenCVForUnityExample;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public WebCamTexture GetWebCamTexture ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OptimizationWebCamTextureToMatHelper), "gameObject")]
    [HutongGames.PlayMaker.ActionTarget (typeof (WebCamTexture), "storeResult")]
    public class OptimizationWebCamTextureToMatHelper_GetWebCamTexture : OptimizationWebCamTextureToHelperComponentAction<OptimizationWebCamTextureToMatHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent (typeof (OptimizationWebCamTextureToMatHelper))]
        [Tooltip ("The GameObject to check.")]
        public HutongGames.PlayMaker.FsmOwnerDefault
            gameObject;

        [HutongGames.PlayMaker.ActionSection ("[return] WebCamTexture(texture)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (WebCamTexture))]
        public HutongGames.PlayMaker.FsmTexture
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            gameObject = null;
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

            storeResult.Value = optimizationWebCamTextureToMatHelper.GetWebCamTexture ();

        }
    }

}
