using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip ("public static SparsePyrLKOpticalFlow create (Size winSize, int maxLevel, TermCriteria crit, int flags, double minEigThreshold)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "winSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "maxLevel")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.TermCriteria), "crit")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "flags")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "minEigThreshold")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow), "storeResult")]
    public class SparsePyrLKOpticalFlow_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject winSize;

        [HutongGames.PlayMaker.ActionSection ("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt maxLevel;

        [HutongGames.PlayMaker.ActionSection ("[arg3] TermCriteria")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.TermCriteria))]
        public HutongGames.PlayMaker.FsmObject crit;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt flags;

        [HutongGames.PlayMaker.ActionSection ("[arg5] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject minEigThreshold;

        [HutongGames.PlayMaker.ActionSection ("[return] SparsePyrLKOpticalFlow")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            winSize = null;
            maxLevel = 0;
            crit = null;
            flags = 0;
            minEigThreshold = null;
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

            if (!(winSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("winSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped_winSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (winSize);

            if (!(crit.Value is OpenCVForUnityPlayMakerActions.TermCriteria))
            {
                LogError ("crit is not initialized. Add Action \"newTermCriteria\".");
                return;
            }
            OpenCVForUnity.CoreModule.TermCriteria wrapped_crit = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TermCriteria, OpenCVForUnity.CoreModule.TermCriteria> (crit);

            if (!(minEigThreshold.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("minEigThreshold is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_minEigThreshold = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (minEigThreshold);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow)) storeResult.Value = new OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow ();
            ((OpenCVForUnityPlayMakerActions.SparsePyrLKOpticalFlow)storeResult.Value).wrappedObject = OpenCVForUnity.VideoModule.SparsePyrLKOpticalFlow.create (wrapped_winSize, maxLevel.Value, wrapped_crit, flags.Value, wrapped_minEigThreshold);


        }

    }

}
