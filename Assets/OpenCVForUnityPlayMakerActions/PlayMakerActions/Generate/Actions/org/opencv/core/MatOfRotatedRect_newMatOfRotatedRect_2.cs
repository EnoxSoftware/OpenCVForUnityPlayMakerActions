using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public MatOfRotatedRect (params RotatedRect[] a)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "a")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfRotatedRect), "storeResult")]
    public class MatOfRotatedRect_newMatOfRotatedRect_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] RotatedRect[](Array(RotatedRect))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.RotatedRect))]
        public HutongGames.PlayMaker.FsmArray a;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfRotatedRect")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfRotatedRect))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            a = null;
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

            OpenCVForUnity.CoreModule.RotatedRect[] wrapped_a = new OpenCVForUnity.CoreModule.RotatedRect[a.Length];
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToArray<OpenCVForUnityPlayMakerActions.RotatedRect, OpenCVForUnity.CoreModule.RotatedRect> (a, wrapped_a);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfRotatedRect)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfRotatedRect ();
            ((OpenCVForUnityPlayMakerActions.MatOfRotatedRect)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.MatOfRotatedRect (wrapped_a);

            OpenCVForUnityPlayMakerActionsUtils.ConvertArrayToFsmArray<OpenCVForUnity.CoreModule.RotatedRect, OpenCVForUnityPlayMakerActions.RotatedRect> (wrapped_a, a);


        }

    }

}
