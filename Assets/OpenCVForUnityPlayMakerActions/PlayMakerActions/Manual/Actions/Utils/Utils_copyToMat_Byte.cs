using UnityEngine;

using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("static void OpenCVForUnity.Utils.copyToMat< byte > ( List< byte > array, Mat mat )")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ByteArray), "array")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "mat")]
    public class Utils_copyToMat_Byte : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] List<byte>(ByteArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ByteArray))]
        public HutongGames.PlayMaker.FsmObject
            array;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            mat;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            array = null;
            mat = null;
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

            System.Byte[] wrapped_array = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ByteArray, System.Byte[]> (array);

            if (!(mat.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("mat is not initialized. Add Action \"newMat\".");
                return;
            }
			OpenCVForUnity.CoreModule.Mat wrapped_mat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (mat);

            MatUtils.copyToMat<byte> (wrapped_array, wrapped_mat);

        }

    }

}
