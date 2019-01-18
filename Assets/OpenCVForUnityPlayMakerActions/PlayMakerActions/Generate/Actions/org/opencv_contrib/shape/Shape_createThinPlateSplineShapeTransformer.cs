using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer (double regularizationParameter)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "regularizationParameter")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer), "storeResult")]
    public class Shape_createThinPlateSplineShapeTransformer : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject regularizationParameter;

        [HutongGames.PlayMaker.ActionSection ("[return] ThinPlateSplineShapeTransformer")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            regularizationParameter = null;
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

            if (!(regularizationParameter.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("regularizationParameter is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_regularizationParameter = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (regularizationParameter);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer)) storeResult.Value = new OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer ();
            ((OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer)storeResult.Value).wrappedObject = OpenCVForUnity.ShapeModule.Shape.createThinPlateSplineShapeTransformer (wrapped_regularizationParameter);


        }

    }

}
