using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public void fromArray (params Point3[] a)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "a")]
    public class MatOfPoint3f_fromArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] MatOfPoint3f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint3f))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Point3[](Array(Point3))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Point3))]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            a = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MatOfPoint3f))
            {
                LogError ("owner is not initialized. Add Action \"newMatOfPoint3f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint3f wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint3f, OpenCVForUnity.MatOfPoint3f> (owner);

            OpenCVForUnity.Point3[] wrapped_a = new OpenCVForUnity.Point3[a.Length];
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToArray<OpenCVForUnityPlayMakerActions.Point3, OpenCVForUnity.Point3> (a, wrapped_a);

            wrapped_owner.fromArray (wrapped_a);

            OpenCVForUnityPlayMakerActionsUtils.ConvertArrayToFsmArray<OpenCVForUnity.Point3, OpenCVForUnityPlayMakerActions.Point3> (wrapped_a, a);


        }

    }

}
