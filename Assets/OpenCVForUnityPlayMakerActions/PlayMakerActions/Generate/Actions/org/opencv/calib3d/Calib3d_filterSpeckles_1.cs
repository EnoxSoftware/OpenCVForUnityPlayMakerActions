using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_calib3d")]
    [HutongGames.PlayMaker.Tooltip ("public static void filterSpeckles (Mat img, double newVal, int maxSpeckleSize, double maxDiff)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "img")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "newVal")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "maxSpeckleSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "maxDiff")]
    public class Calib3d_filterSpeckles_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject img;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject newVal;

        [HutongGames.PlayMaker.ActionSection ("[arg3] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt maxSpeckleSize;

        [HutongGames.PlayMaker.ActionSection ("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject maxDiff;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            img = null;
            newVal = null;
            maxSpeckleSize = 0;
            maxDiff = null;
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

            if (!(img.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("img is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_img = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (img);

            if (!(newVal.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("newVal is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_newVal = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (newVal);

            if (!(maxDiff.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("maxDiff is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_maxDiff = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (maxDiff);

            OpenCVForUnity.Calib3d.filterSpeckles (wrapped_img, wrapped_newVal, maxSpeckleSize.Value, wrapped_maxDiff);


        }

    }

}
