using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyColor), "storeResult")]
    public class Ximgproc_createSelectiveSearchSegmentationStrategyColor : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[return] SelectiveSearchSegmentationStrategyColor")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyColor))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyColor)) storeResult.Value = new OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyColor ();
            ((OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyColor)storeResult.Value).wrappedObject = OpenCVForUnity.Ximgproc.createSelectiveSearchSegmentationStrategyColor ();


        }

    }

}
