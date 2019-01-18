using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer), "storeResult")]
    public class Shape_createThinPlateSplineShapeTransformer_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[return] ThinPlateSplineShapeTransformer")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
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
            ((OpenCVForUnityPlayMakerActions.ThinPlateSplineShapeTransformer)storeResult.Value).wrappedObject = OpenCVForUnity.ShapeModule.Shape.createThinPlateSplineShapeTransformer ();


        }

    }

}
