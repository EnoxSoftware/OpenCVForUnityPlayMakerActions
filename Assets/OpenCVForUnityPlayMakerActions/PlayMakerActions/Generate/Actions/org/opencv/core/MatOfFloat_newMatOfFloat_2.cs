using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public MatOfFloat(params float[] a)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "a")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat), "storeResult")]
    public class MatOfFloat_newMatOfFloat_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] float[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection("[return] MatOfFloat")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat))]
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

            float[] float_a = a.floatValues;
            float[] casted_a = new float[float_a.Length];
            for (int i = 0; i < casted_a.Length; i++)
            {
                casted_a[i] = (float)float_a[i];
            }

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfFloat)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfFloat();
            ((OpenCVForUnityPlayMakerActions.MatOfFloat)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.MatOfFloat(casted_a);

            for (int i = 0; i < casted_a.Length; i++)
            {
                a.Set(i, (float)casted_a[i]);
            }
            a.SaveChanges();


        }

    }

}
