using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public static void ellipse (Mat img, RotatedRect box, Scalar color, int thickness)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "img")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.RotatedRect), "box")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "color")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "thickness")]
    public class Imgproc_ellipse_4 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject img;

        [HutongGames.PlayMaker.ActionSection ("[arg2] RotatedRect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.RotatedRect))]
        public HutongGames.PlayMaker.FsmObject box;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Scalar")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject color;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt thickness;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            img = null;
            box = null;
            color = null;
            thickness = 0;
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

            if (!(box.Value is OpenCVForUnityPlayMakerActions.RotatedRect))
            {
                LogError ("box is not initialized. Add Action \"newRotatedRect\".");
                return;
            }
            OpenCVForUnity.RotatedRect wrapped_box = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.RotatedRect, OpenCVForUnity.RotatedRect> (box);

            if (!(color.Value is OpenCVForUnityPlayMakerActions.Scalar))
            {
                LogError ("color is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.Scalar wrapped_color = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.Scalar> (color);

            OpenCVForUnity.Imgproc.ellipse (wrapped_img, wrapped_box, wrapped_color, thickness.Value);


        }

    }

}
