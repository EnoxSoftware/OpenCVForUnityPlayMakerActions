#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip ("public static void detectRegions (Mat image, ERFilter er_filter1, ERFilter er_filter2, List<MatOfPoint> regions)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "image")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ERFilter), "er_filter1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ERFilter), "er_filter2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "regions")]
    public class Text_detectRegions_4 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject image;

        [HutongGames.PlayMaker.ActionSection ("[arg2] ERFilter")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ERFilter))]
        public HutongGames.PlayMaker.FsmObject er_filter1;

        [HutongGames.PlayMaker.ActionSection ("[arg3] ERFilter")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ERFilter))]
        public HutongGames.PlayMaker.FsmObject er_filter2;

        [HutongGames.PlayMaker.ActionSection ("[arg4] List<MatOfPoint>(Array(MatOfPoint))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint))]
        public HutongGames.PlayMaker.FsmArray regions;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            image = null;
            er_filter1 = null;
            er_filter2 = null;
            regions = null;
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

            if (!(image.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("image is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_image = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (image);

            if (!(er_filter1.Value is OpenCVForUnityPlayMakerActions.ERFilter))
            {
                LogError ("er_filter1 is not initialized. Add Action \"newERFilter\".");
                return;
            }
            OpenCVForUnity.ERFilter wrapped_er_filter1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ERFilter, OpenCVForUnity.ERFilter> (er_filter1);

            if (!(er_filter2.Value is OpenCVForUnityPlayMakerActions.ERFilter))
            {
                LogError ("er_filter2 is not initialized. Add Action \"newERFilter\".");
                return;
            }
            OpenCVForUnity.ERFilter wrapped_er_filter2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ERFilter, OpenCVForUnity.ERFilter> (er_filter2);

            List<OpenCVForUnity.MatOfPoint> wrapped_regions = new List<OpenCVForUnity.MatOfPoint> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfPoint, OpenCVForUnity.MatOfPoint> (regions, wrapped_regions);

            OpenCVForUnity.Text.detectRegions (wrapped_image, wrapped_er_filter1, wrapped_er_filter2, wrapped_regions);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfPoint, OpenCVForUnityPlayMakerActions.MatOfPoint> (wrapped_regions, regions);


        }

    }

}
#endif
