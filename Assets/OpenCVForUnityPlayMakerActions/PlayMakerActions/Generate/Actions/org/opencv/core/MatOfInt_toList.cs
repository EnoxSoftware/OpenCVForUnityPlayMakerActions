using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public List<int> toList()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfInt), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "storeResult")]
    public class MatOfInt_toList : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] MatOfInt")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[return] List<int>(Array(int))")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfInt))
            {
                LogError("owner is not initialized. Add Action \"newMatOfInt\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfInt wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.CoreModule.MatOfInt>(owner);

            List<int> wrapped_storeResult = wrapped_owner.toList();

            if (!storeResult.IsNone)
            {
                if (storeResult.Length != wrapped_storeResult.Count) storeResult.Resize(wrapped_storeResult.Count);
                for (int i = 0; i < wrapped_storeResult.Count; i++)
                {
                    storeResult.Set(i, (int)wrapped_storeResult[i]);
                }
                storeResult.SaveChanges();
            }


        }

    }

}
