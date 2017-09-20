using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public static HistogramCostExtractor createNormHistogramCostExtractor (int flag, int nDummies, float defaultCost)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "flag")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "nDummies")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "defaultCost")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.HistogramCostExtractor), "storeResult")]
    public class Shape_createNormHistogramCostExtractor : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt flag;

        [HutongGames.PlayMaker.ActionSection ("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt nDummies;

        [HutongGames.PlayMaker.ActionSection ("[arg3] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat defaultCost;

        [HutongGames.PlayMaker.ActionSection ("[return] HistogramCostExtractor")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.HistogramCostExtractor))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            flag = 0;
            nDummies = 0;
            defaultCost = 0.0f;
            storeResult = null;
            everyFrame = false;
        }

        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame)
            {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HistogramCostExtractor)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HistogramCostExtractor ();
            ((OpenCVForUnityPlayMakerActions.HistogramCostExtractor)storeResult.Value).wrappedObject = OpenCVForUnity.Shape.createNormHistogramCostExtractor (flag.Value, nDummies.Value, defaultCost.Value);


        }

    }

}
