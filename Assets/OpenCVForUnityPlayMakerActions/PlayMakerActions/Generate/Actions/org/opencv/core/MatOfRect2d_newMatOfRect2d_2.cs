using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public MatOfRect2d(params Rect2d[] a)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "a")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfRect2d), "storeResult")]
    public class MatOfRect2d_newMatOfRect2d_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] Rect2d[](Array(Rect2d))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor(typeof(OpenCVForUnityPlayMakerActions.Rect2d))]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection("[return] MatOfRect2d")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfRect2d))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            a = null;
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

            OpenCVForUnity.CoreModule.Rect2d[] wrapped_a = new OpenCVForUnity.CoreModule.Rect2d[a.Length];
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToArray<OpenCVForUnityPlayMakerActions.Rect2d, OpenCVForUnity.CoreModule.Rect2d>(a, wrapped_a);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfRect2d)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfRect2d();
            ((OpenCVForUnityPlayMakerActions.MatOfRect2d)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.MatOfRect2d(wrapped_a);

            OpenCVForUnityPlayMakerActionsUtils.ConvertArrayToFsmArray<OpenCVForUnity.CoreModule.Rect2d, OpenCVForUnityPlayMakerActions.Rect2d>(wrapped_a, a);


        }

    }

}
