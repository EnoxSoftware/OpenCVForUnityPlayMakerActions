using UnityEngine;

using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static void fastMatToTexture2D (Mat mat, Texture2D texture2D)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "mat")]
    [HutongGames.PlayMaker.ActionTarget (typeof (Texture2D), "texture2D")]
    public class Utils_fastMatToTexture2D : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            mat;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Texture2D(texture)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (Texture2D))]
        public HutongGames.PlayMaker.FsmTexture
            texture2D;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            mat = null;
            texture2D = null;
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
            if (!(mat.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("mat is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_mat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (mat);

            Utils.fastMatToTexture2D (wrapped_mat, texture2D.Value as Texture2D);

        }


    }

}
