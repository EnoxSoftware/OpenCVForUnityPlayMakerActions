using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy), "s1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy), "s2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy), "s3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyMultiple), "storeResult")]
    public class Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] SelectiveSearchSegmentationStrategy")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy))]
        public HutongGames.PlayMaker.FsmObject s1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] SelectiveSearchSegmentationStrategy")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy))]
        public HutongGames.PlayMaker.FsmObject s2;

        [HutongGames.PlayMaker.ActionSection ("[arg3] SelectiveSearchSegmentationStrategy")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy))]
        public HutongGames.PlayMaker.FsmObject s3;

        [HutongGames.PlayMaker.ActionSection ("[return] SelectiveSearchSegmentationStrategyMultiple")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyMultiple))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            s1 = null;
            s2 = null;
            s3 = null;
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

            if (!(s1.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy))
            {
                LogError ("s1 is not initialized. Add Action \"newSelectiveSearchSegmentationStrategy\".");
                return;
            }
            OpenCVForUnity.SelectiveSearchSegmentationStrategy wrapped_s1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy, OpenCVForUnity.SelectiveSearchSegmentationStrategy> (s1);

            if (!(s2.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy))
            {
                LogError ("s2 is not initialized. Add Action \"newSelectiveSearchSegmentationStrategy\".");
                return;
            }
            OpenCVForUnity.SelectiveSearchSegmentationStrategy wrapped_s2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy, OpenCVForUnity.SelectiveSearchSegmentationStrategy> (s2);

            if (!(s3.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy))
            {
                LogError ("s3 is not initialized. Add Action \"newSelectiveSearchSegmentationStrategy\".");
                return;
            }
            OpenCVForUnity.SelectiveSearchSegmentationStrategy wrapped_s3 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategy, OpenCVForUnity.SelectiveSearchSegmentationStrategy> (s3);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyMultiple)) storeResult.Value = new OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyMultiple ();
            ((OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentationStrategyMultiple)storeResult.Value).wrappedObject = OpenCVForUnity.Ximgproc.createSelectiveSearchSegmentationStrategyMultiple (wrapped_s1, wrapped_s2, wrapped_s3);


        }

    }

}
