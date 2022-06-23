using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public MatOfInt(params int[] a)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "a")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfInt), "storeResult")]
    public class MatOfInt_newMatOfInt_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection("[return] MatOfInt")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfInt))]
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

            int[] int_a = a.intValues;
            int[] casted_a = new int[int_a.Length];
            for (int i = 0; i < casted_a.Length; i++)
            {
                casted_a[i] = (int)int_a[i];
            }

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfInt)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfInt();
            ((OpenCVForUnityPlayMakerActions.MatOfInt)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.MatOfInt(casted_a);

            for (int i = 0; i < casted_a.Length; i++)
            {
                a.Set(i, (int)casted_a[i]);
            }
            a.SaveChanges();


        }

    }

}
