using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_core")]
    [HutongGames.PlayMaker.Tooltip ("public MatOfByte (params byte[] a)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ByteArray), "a")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfByte), "storeResult")]
    public class MatOfByte_newMatOfByte_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] byte[](ByteArray)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ByteArray))]
        public HutongGames.PlayMaker.FsmObject a;

        [HutongGames.PlayMaker.ActionSection ("[return] MatOfByte")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfByte))]
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

            if (!(a.Value is OpenCVForUnityPlayMakerActions.ByteArray))
            {
                LogError ("a is not initialized. Add Action \"newByteArray\".");
                return;
            }
            System.Byte[] wrapped_a = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ByteArray, System.Byte[]> (a);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MatOfByte)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MatOfByte ();
            ((OpenCVForUnityPlayMakerActions.MatOfByte)storeResult.Value).wrappedObject = new OpenCVForUnity.CoreModule.MatOfByte (wrapped_a);


        }

    }

}
