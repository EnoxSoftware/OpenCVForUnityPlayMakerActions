using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public Rect2d (double[] vals)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DoubleArray), "vals")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Rect2d), "storeResult")]
    public class Rect2d_newRect2d_4 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double[](DoubleArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DoubleArray))]
        public HutongGames.PlayMaker.FsmObject vals;

        [HutongGames.PlayMaker.ActionSection ("[return] Rect2d")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Rect2d))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            vals = null;
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

            if (!(vals.Value is OpenCVForUnityPlayMakerActions.DoubleArray))
            {
                LogError ("vals is not initialized. Add Action \"newDoubleArray\".");
                return;
            }
            System.Double[] wrapped_vals = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.DoubleArray, System.Double[]> (vals);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Rect2d)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Rect2d ();
            ((OpenCVForUnityPlayMakerActions.Rect2d)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.Rect2d (wrapped_vals);


        }

    }

}
