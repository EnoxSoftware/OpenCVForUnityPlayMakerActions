using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static AdaptiveManifoldFilter createAMFilter (double sigma_s, double sigma_r)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_s")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "sigma_r")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.AdaptiveManifoldFilter), "storeResult")]
    public class Ximgproc_createAMFilter_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_s;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject sigma_r;

        [HutongGames.PlayMaker.ActionSection ("[return] AdaptiveManifoldFilter")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.AdaptiveManifoldFilter))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            sigma_s = null;
            sigma_r = null;
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

            if (!(sigma_s.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_s is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_s = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_s);

            if (!(sigma_r.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("sigma_r is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_sigma_r = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (sigma_r);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.AdaptiveManifoldFilter)) storeResult.Value = new OpenCVForUnityPlayMakerActions.AdaptiveManifoldFilter ();
            ((OpenCVForUnityPlayMakerActions.AdaptiveManifoldFilter)storeResult.Value).wrappedObject = OpenCVForUnity.Ximgproc.createAMFilter (wrapped_sigma_s, wrapped_sigma_r);


        }

    }

}
