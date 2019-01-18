using UnityEngine;

using OpenCVForUnity.UnityUtils.Helper;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public void Pause ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (WebCamTextureToMatHelper), "gameObject")]
    public class WebCamTextureToMatHelper_Pause : WebCamTextureToHelperComponentAction<WebCamTextureToMatHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent (typeof (WebCamTextureToMatHelper))]
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

            webCamTextureToMatHelper.Pause ();

        }
    }

}
