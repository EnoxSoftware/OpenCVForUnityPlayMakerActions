using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public static HausdorffDistanceExtractor createHausdorffDistanceExtractor (int distanceFlag, float rankProp)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "distanceFlag")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "rankProp")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.HausdorffDistanceExtractor), "storeResult")]
    public class Shape_createHausdorffDistanceExtractor : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt distanceFlag;

        [HutongGames.PlayMaker.ActionSection ("[arg2] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat rankProp;

        [HutongGames.PlayMaker.ActionSection ("[return] HausdorffDistanceExtractor")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.HausdorffDistanceExtractor))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            distanceFlag = 0;
            rankProp = 0.0f;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HausdorffDistanceExtractor)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HausdorffDistanceExtractor ();
            ((OpenCVForUnityPlayMakerActions.HausdorffDistanceExtractor)storeResult.Value).wrappedObject = OpenCVForUnity.Shape.createHausdorffDistanceExtractor (distanceFlag.Value, rankProp.Value);


        }

    }

}
