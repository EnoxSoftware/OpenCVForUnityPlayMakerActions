using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public double getRegularizationParameter ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "storeResult")]
    public class ThinPlateSplineShapeTransformer_getRegularizationParameter : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] ThinPlateSplineShapeTransformer")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[return] double(Double)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer))
            {
                LogError ("owner is not initialized. Add Action \"newThinPlateSplineShapeTransformer\".");
                return;
            }
            OpenCVForUnity.ThinPlateSplineShapeTransformer wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer, OpenCVForUnity.ThinPlateSplineShapeTransformer> (owner);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Double)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Double ();
            ((OpenCVForUnityPlayMakerActions.Double)storeResult.Value).wrappedObject = wrapped_owner.getRegularizationParameter ();


        }

    }

}
