using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static void getRectSubPix (Mat image, Size patchSize, Point center, Mat patch, int patchType)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "image")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "patchSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Point), "center")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "patch")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "patchType")]
    public class Imgproc_getRectSubPix : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject image;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject patchSize;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Point")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Point))]
        public HutongGames.PlayMaker.FsmObject center;

        [HutongGames.PlayMaker.ActionSection ("[arg4] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject patch;

        [HutongGames.PlayMaker.ActionSection ("[arg5] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt patchType;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            image = null;
            patchSize = null;
            center = null;
            patch = null;
            patchType = 0;
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

            if (!(patchSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("patchSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.Size wrapped_patchSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.Size> (patchSize);

            if (!(center.Value is OpenCVForUnityPlayMakerActions.Point))
            {
                LogError ("center is not initialized. Add Action \"newPoint\".");
                return;
            }
            OpenCVForUnity.Point wrapped_center = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Point, OpenCVForUnity.Point> (center);

            if (!(patch.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("patch is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_patch = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (patch);

            OpenCVForUnity.Imgproc.getRectSubPix (wrapped_image, wrapped_patchSize, wrapped_center, wrapped_patch, patchType.Value);


        }

    }

}
