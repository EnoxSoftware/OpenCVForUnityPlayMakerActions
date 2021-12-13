using UnityEngine;

using OpenCVForUnity.UnityUtils.Helper;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip("public void Dispose ()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(ImageOptimizationHelper), "gameObject")]
    public class ImageOptimizationHelper_Dispose : ImageOptimizationHelperComponentAction<ImageOptimizationHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent(typeof(ImageOptimizationHelper))]
        [Tooltip("The GameObject to check.")]
        public HutongGames.PlayMaker.FsmOwnerDefault
            gameObject;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool
            everyFrame;


        public override void Reset()
        {
            gameObject = null;
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
            var go = Fsm.GetOwnerDefaultTarget(gameObject);

            if (!UpdateCache(go))
            {
                return;
            }

            imageOptimizationHelper.Dispose();

        }
    }

}
