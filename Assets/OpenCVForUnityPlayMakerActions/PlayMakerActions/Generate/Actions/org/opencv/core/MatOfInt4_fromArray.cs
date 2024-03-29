using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public void fromArray(params int[] a)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfInt4), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "a")]
    public class MatOfInt4_fromArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] MatOfInt4")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfInt4))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            a = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfInt4))
            {
                LogError("owner is not initialized. Add Action \"newMatOfInt4\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfInt4 wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt4, OpenCVForUnity.CoreModule.MatOfInt4>(owner);

            int[] int_a = a.intValues;
            int[] casted_a = new int[int_a.Length];
            for (int i = 0; i < casted_a.Length; i++)
            {
                casted_a[i] = (int)int_a[i];
            }

            wrapped_owner.fromArray(casted_a);

            for (int i = 0; i < casted_a.Length; i++)
            {
                a.Set(i, (int)casted_a[i]);
            }
            a.SaveChanges();


        }

    }

}
