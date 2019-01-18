using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_video")]
    [HutongGames.PlayMaker.Tooltip ("public static FarnebackOpticalFlow create (int numLevels, double pyrScale, bool fastPyramids)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "numLevels")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "pyrScale")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "fastPyramids")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.FarnebackOpticalFlow), "storeResult")]
    public class FarnebackOpticalFlow_create_5 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt numLevels;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject pyrScale;

        [HutongGames.PlayMaker.ActionSection ("[arg3] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool fastPyramids;

        [HutongGames.PlayMaker.ActionSection ("[return] FarnebackOpticalFlow")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.FarnebackOpticalFlow))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            numLevels = 0;
            pyrScale = null;
            fastPyramids = false;
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

            if (!(pyrScale.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("pyrScale is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_pyrScale = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (pyrScale);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.FarnebackOpticalFlow)) storeResult.Value = new OpenCVForUnityPlayMakerActions.FarnebackOpticalFlow ();
            ((OpenCVForUnityPlayMakerActions.FarnebackOpticalFlow)storeResult.Value).wrappedObject = OpenCVForUnity.VideoModule.FarnebackOpticalFlow.create (numLevels.Value, wrapped_pyrScale, fastPyramids.Value);


        }

    }

}
