using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static DTFilter createDTFilter (Mat guide, double sigmaSpatial, double sigmaColor)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "guide")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "sigmaSpatial")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "sigmaColor")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DTFilter), "storeResult")]
    public class Ximgproc_createDTFilter_1_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject guide;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat sigmaSpatial;

        [HutongGames.PlayMaker.ActionSection ("[arg3] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat sigmaColor;

        [HutongGames.PlayMaker.ActionSection ("[return] DTFilter")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DTFilter))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            guide = null;
            sigmaSpatial = 0.0f;
            sigmaColor = 0.0f;
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

            if (!(guide.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("guide is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_guide = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (guide);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.DTFilter)) storeResult.Value = new OpenCVForUnityPlayMakerActions.DTFilter ();
            ((OpenCVForUnityPlayMakerActions.DTFilter)storeResult.Value).wrappedObject = OpenCVForUnity.Ximgproc.createDTFilter (wrapped_guide, (float)sigmaSpatial.Value, (float)sigmaColor.Value);


        }

    }

}
