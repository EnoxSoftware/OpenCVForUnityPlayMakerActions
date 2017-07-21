using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static MatOfRect2d fromNativeAddr (IntPtr addr)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.IntPtr), "addr")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfRect2d), "storeResult")]
    public class MatOfRect2d_fromNativeAddr : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] IntPtr")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.IntPtr))]
        public HutongGames.PlayMaker.FsmObject addr;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfRect2d")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfRect2d))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            addr = null;
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

            if (!(addr.Value is OpenCVForUnityPlayMakerActions.IntPtr))
            {
                LogError ("addr is not initialized. Add Action \"newIntPtr\".");
                return;
            }
            System.IntPtr wrapped_addr = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.IntPtr, System.IntPtr> (addr);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfRect2d)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfRect2d ();
            ((OpenCVForUnityPlayMakerActions.MatOfRect2d)storeResult.Value).wrappedObject = OpenCVForUnity.MatOfRect2d.fromNativeAddr (wrapped_addr);


        }

    }

}
