using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public List<Point> toList()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfPoint2f), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "storeResult")]
    public class MatOfPoint2f_toList : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] MatOfPoint2f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[return] List<Point>(Array(Point))")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor(typeof(OpenCVForUnityPlayMakerActions.Point))]
        public HutongGames.PlayMaker.FsmArray storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f))
            {
                LogError("owner is not initialized. Add Action \"newMatOfPoint2f\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfPoint2f wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.CoreModule.MatOfPoint2f>(owner);

            List<OpenCVForUnity.CoreModule.Point> wrapped_storeResult = wrapped_owner.toList();

            if (!storeResult.IsNone)
            {
                OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.CoreModule.Point, OpenCVForUnityPlayMakerActions.Point>(wrapped_storeResult, storeResult);
            }


        }

    }

}
