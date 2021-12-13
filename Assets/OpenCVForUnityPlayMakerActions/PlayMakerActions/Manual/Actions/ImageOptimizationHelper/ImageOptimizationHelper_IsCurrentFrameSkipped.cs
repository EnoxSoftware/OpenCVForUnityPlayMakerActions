using UnityEngine;

using OpenCVForUnity.UnityUtils.Helper;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip("public virtual bool IsCurrentFrameSkipped ()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(ImageOptimizationHelper), "gameObject")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmEvent), "trueEvent")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmEvent), "falseEvent")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "storeResult")]
    public class OptimizationWebCamTextureToMatHelper_IsCurrentFrameSkipped : ImageOptimizationHelperComponentAction<ImageOptimizationHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent(typeof(ImageOptimizationHelper))]
        [Tooltip("The GameObject to check.")]
        public HutongGames.PlayMaker.FsmOwnerDefault
            gameObject;

        [HutongGames.PlayMaker.ActionSection("[return] bool")]

        [HutongGames.PlayMaker.Tooltip("Event to send if result is true.")]
        public HutongGames.PlayMaker.FsmEvent
            trueEvent;

        [HutongGames.PlayMaker.Tooltip("Event to send if result is false.")]
        public HutongGames.PlayMaker.FsmEvent
            falseEvent;

        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool
            storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset()
        {
            gameObject = null;
            trueEvent = null;
            falseEvent = null;
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
            var go = Fsm.GetOwnerDefaultTarget(gameObject);

            if (!UpdateCache(go))
            {
                return;
            }

            storeResult.Value = imageOptimizationHelper.IsCurrentFrameSkipped();
            Fsm.Event(storeResult.Value ? trueEvent : falseEvent);

        }
    }

}
