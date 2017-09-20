using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public HistogramCostExtractor getCostExtractor ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ShapeContextDistanceExtractor), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.HistogramCostExtractor), "storeResult")]
    public class ShapeContextDistanceExtractor_getCostExtractor : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] ShapeContextDistanceExtractor")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ShapeContextDistanceExtractor))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[return] HistogramCostExtractor")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.HistogramCostExtractor))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.ShapeContextDistanceExtractor))
            {
                LogError ("owner is not initialized. Add Action \"newShapeContextDistanceExtractor\".");
                return;
            }
            OpenCVForUnity.ShapeContextDistanceExtractor wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ShapeContextDistanceExtractor, OpenCVForUnity.ShapeContextDistanceExtractor> (owner);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HistogramCostExtractor)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HistogramCostExtractor ();
            ((OpenCVForUnityPlayMakerActions.HistogramCostExtractor)storeResult.Value).wrappedObject = wrapped_owner.getCostExtractor ();


        }

    }

}
