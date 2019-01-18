using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public void fromList (List<KeyPoint> lkp)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "lkp")]
    public class MatOfKeyPoint_fromList : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] MatOfKeyPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] List<KeyPoint>(Array(KeyPoint))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.KeyPoint))]
        public HutongGames.PlayMaker.FsmArray lkp;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            lkp = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("owner is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfKeyPoint wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.CoreModule.MatOfKeyPoint> (owner);

            List<OpenCVForUnity.CoreModule.KeyPoint> wrapped_lkp = new List<OpenCVForUnity.CoreModule.KeyPoint> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.KeyPoint, OpenCVForUnity.CoreModule.KeyPoint> (lkp, wrapped_lkp);

            wrapped_owner.fromList (wrapped_lkp);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.CoreModule.KeyPoint, OpenCVForUnityPlayMakerActions.KeyPoint> (wrapped_lkp, lkp);


        }

    }

}
