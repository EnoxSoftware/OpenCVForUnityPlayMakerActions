using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public static MatOfPoint2f fromNativeAddr (IntPtr addr)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.IntPtr), "addr")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f), "storeResult")]
    public class MatOfPoint2f_fromNativeAddr : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] IntPtr")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.IntPtr))]
        public HutongGames.PlayMaker.FsmObject addr;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfPoint2f")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfPoint2f ();
            ((OpenCVForUnityPlayMakerActions.MatOfPoint2f)storeResult.Value).wrappedObject = OpenCVForUnity.MatOfPoint2f.fromNativeAddr (wrapped_addr);


        }

    }

}
