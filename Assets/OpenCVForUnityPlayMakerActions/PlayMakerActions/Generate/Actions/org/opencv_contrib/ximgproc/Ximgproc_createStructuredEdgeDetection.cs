using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static StructuredEdgeDetection createStructuredEdgeDetection (string model, RFFeatureGetter howToGetFeatures)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "model")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.RFFeatureGetter), "howToGetFeatures")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.StructuredEdgeDetection), "storeResult")]
    public class Ximgproc_createStructuredEdgeDetection : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString model;

        [HutongGames.PlayMaker.ActionSection ("[arg2] RFFeatureGetter")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.RFFeatureGetter))]
        public HutongGames.PlayMaker.FsmObject howToGetFeatures;

        [HutongGames.PlayMaker.ActionSection ("[return] StructuredEdgeDetection")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.StructuredEdgeDetection))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            model = null;
            howToGetFeatures = null;
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

            if (!(howToGetFeatures.Value is OpenCVForUnityPlayMakerActions.RFFeatureGetter))
            {
                LogError ("howToGetFeatures is not initialized. Add Action \"newRFFeatureGetter\".");
                return;
            }
            OpenCVForUnity.XimgprocModule.RFFeatureGetter wrapped_howToGetFeatures = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.RFFeatureGetter, OpenCVForUnity.XimgprocModule.RFFeatureGetter> (howToGetFeatures);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.StructuredEdgeDetection)) storeResult.Value = new OpenCVForUnityPlayMakerActions.StructuredEdgeDetection ();
            ((OpenCVForUnityPlayMakerActions.StructuredEdgeDetection)storeResult.Value).wrappedObject = OpenCVForUnity.XimgprocModule.Ximgproc.createStructuredEdgeDetection (model.Value, wrapped_howToGetFeatures);


        }

    }

}
