using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip("public Point3(double[] vals)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "vals")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Point3), "storeResult")]
    public class Point3_newPoint3_3_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] double[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray vals;

        [HutongGames.PlayMaker.ActionSection("[return] Point3")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Point3))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            vals = null;
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

            float[] float_vals = vals.floatValues;
            double[] casted_vals = new double[float_vals.Length];
            float_vals.CopyTo(casted_vals, 0);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Point3)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Point3();
            ((OpenCVForUnityPlayMakerActions.Point3)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.Point3(casted_vals);

            for (int i = 0; i < casted_vals.Length; i++)
            {
                float_vals[i] = (float)casted_vals[i];
            }


        }

    }

}
