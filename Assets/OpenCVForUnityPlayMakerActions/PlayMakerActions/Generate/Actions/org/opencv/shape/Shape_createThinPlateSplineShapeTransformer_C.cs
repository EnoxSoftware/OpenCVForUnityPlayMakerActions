using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer (double regularizationParameter)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "regularizationParameter")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer), "storeResult")]
    public class Shape_createThinPlateSplineShapeTransformer_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat regularizationParameter;

        [HutongGames.PlayMaker.ActionSection ("[return] ThinPlateSplineShapeTransformer")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            regularizationParameter = 0.0f;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer)) storeResult.Value = new OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer ();
            ((OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer)storeResult.Value).wrappedObject = OpenCVForUnity.Shape.createThinPlateSplineShapeTransformer ((float)regularizationParameter.Value);


        }

    }

}
