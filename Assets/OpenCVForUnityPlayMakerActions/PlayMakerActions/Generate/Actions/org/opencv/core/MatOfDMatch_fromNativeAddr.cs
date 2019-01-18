using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public static MatOfDMatch fromNativeAddr (IntPtr addr)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.IntPtr), "addr")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch), "storeResult")]
    public class MatOfDMatch_fromNativeAddr : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] IntPtr")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.IntPtr))]
        public HutongGames.PlayMaker.FsmObject addr;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfDMatch")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch))]
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfDMatch)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfDMatch ();
            ((OpenCVForUnityPlayMakerActions.MatOfDMatch)storeResult.Value).wrappedObject = OpenCVForUnity.CoreModule.MatOfDMatch.fromNativeAddr (wrapped_addr);


        }

    }

}
