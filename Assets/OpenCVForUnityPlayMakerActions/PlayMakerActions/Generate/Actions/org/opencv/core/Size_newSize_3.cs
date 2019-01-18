using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public Size (double[] vals)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DoubleArray), "vals")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "storeResult")]
    public class Size_newSize_3 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double[](DoubleArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DoubleArray))]
        public HutongGames.PlayMaker.FsmObject vals;

        [HutongGames.PlayMaker.ActionSection ("[return] Size")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Size)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Size ();
            ((OpenCVForUnityPlayMakerActions.Size)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.Size (wrapped_vals);


        }

    }

}
