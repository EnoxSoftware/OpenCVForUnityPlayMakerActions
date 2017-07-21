using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static MatOfInt fromNativeAddr (IntPtr addr)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.IntPtr), "addr")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "storeResult")]
    public class MatOfInt_fromNativeAddr : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] IntPtr")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.IntPtr))]
        public HutongGames.PlayMaker.FsmObject addr;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfInt")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfInt)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfInt ();
            ((OpenCVForUnityPlayMakerActions.MatOfInt)storeResult.Value).wrappedObject = OpenCVForUnity.MatOfInt.fromNativeAddr (wrapped_addr);


        }

    }

}
