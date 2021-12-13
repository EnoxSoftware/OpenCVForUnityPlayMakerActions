using UnityEngine;

using OpenCVForUnity.UnityUtils.Helper;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip("public virtual void Initialize (string deviceName, int requestedWidth, int requestedHeight, bool requestedIsFrontFacing = false, int requestedFPS = 30)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(WebCamTextureToMatHelper), "gameObject")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "deviceName")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "requestedWidth")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "requestedHeight")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "requestedIsFrontFacing")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "requestedFPS")]
    public class WebCamTextureToMatHelper_Initialize_1 : WebCamTextureToHelperComponentAction<WebCamTextureToMatHelper>
    {
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.CheckForComponent(typeof(WebCamTextureToMatHelper))]
        [Tooltip("The GameObject to check.")]
        public HutongGames.PlayMaker.FsmOwnerDefault
            gameObject;

        [HutongGames.PlayMaker.ActionSection("[arg1] string")]
        public HutongGames.PlayMaker.FsmString
            deviceName;

        [HutongGames.PlayMaker.ActionSection("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        public HutongGames.PlayMaker.FsmInt
            requestedWidth;

        [HutongGames.PlayMaker.ActionSection("[arg3] int")]
        [HutongGames.PlayMaker.RequiredField]
        public HutongGames.PlayMaker.FsmInt
            requestedHeight;

        [HutongGames.PlayMaker.ActionSection("[arg4] bool")]
        public HutongGames.PlayMaker.FsmBool
            requestedIsFrontFacing;

        [HutongGames.PlayMaker.ActionSection("[arg5] int")]
        public HutongGames.PlayMaker.FsmInt
            requestedFPS;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset()
        {
            gameObject = null;
            deviceName = null;
            requestedWidth = 640;
            requestedHeight = 480;
            requestedIsFrontFacing = false;
            requestedFPS = 30;
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

            webCamTextureToMatHelper.Initialize(deviceName.Value, requestedWidth.Value, requestedHeight.Value, requestedIsFrontFacing.Value, requestedFPS.Value);

        }
    }

}
