using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip("public void filter(Mat disparity_map_left, Mat left_view, Mat filtered_disparity_map, Mat disparity_map_right, Rect ROI, Mat right_view)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.DisparityFilter), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "disparity_map_left")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "left_view")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "filtered_disparity_map")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "disparity_map_right")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Rect), "ROI")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "right_view")]
    public class DisparityFilter_filter : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] DisparityFilter")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.DisparityFilter))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject disparity_map_left;

        [HutongGames.PlayMaker.ActionSection("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject left_view;

        [HutongGames.PlayMaker.ActionSection("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject filtered_disparity_map;

        [HutongGames.PlayMaker.ActionSection("[arg4] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject disparity_map_right;

        [HutongGames.PlayMaker.ActionSection("[arg5] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Rect))]
        public HutongGames.PlayMaker.FsmObject ROI;

        [HutongGames.PlayMaker.ActionSection("[arg6] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject right_view;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            disparity_map_left = null;
            left_view = null;
            filtered_disparity_map = null;
            disparity_map_right = null;
            ROI = null;
            right_view = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoProcess();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoProcess();
        }

        void DoProcess()
        {

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.DisparityFilter))
            {
                LogError("owner is not initialized. Add Action \"newDisparityFilter\".");
                return;
            }
            OpenCVForUnity.XimgprocModule.DisparityFilter wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.DisparityFilter, OpenCVForUnity.XimgprocModule.DisparityFilter>(owner);

            if (!(disparity_map_left.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("disparity_map_left is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_disparity_map_left = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(disparity_map_left);

            if (!(left_view.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("left_view is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_left_view = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(left_view);

            if (!(filtered_disparity_map.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("filtered_disparity_map is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_filtered_disparity_map = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(filtered_disparity_map);

            if (!(disparity_map_right.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("disparity_map_right is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_disparity_map_right = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(disparity_map_right);

            if (!(ROI.Value is OpenCVForUnityPlayMakerActions.Rect))
            {
                LogError("ROI is not initialized. Add Action \"newRect\".");
                return;
            }
            OpenCVForUnity.CoreModule.Rect wrapped_ROI = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Rect, OpenCVForUnity.CoreModule.Rect>(ROI);

            if (!(right_view.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("right_view is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_right_view = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(right_view);

            wrapped_owner.filter(wrapped_disparity_map_left, wrapped_left_view, wrapped_filtered_disparity_map, wrapped_disparity_map_right, wrapped_ROI, wrapped_right_view);


        }

    }

}
