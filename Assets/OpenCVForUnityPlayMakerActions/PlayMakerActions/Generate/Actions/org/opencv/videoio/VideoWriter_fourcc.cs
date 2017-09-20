using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_videoio")]
    [HutongGames.PlayMaker.Tooltip ("public static int fourcc (char c1, char c2, char c3, char c4)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Char), "c1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Char), "c2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Char), "c3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Char), "c4")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "storeResult")]
    public class VideoWriter_fourcc : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] char(Char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Char))]
        public HutongGames.PlayMaker.FsmObject c1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] char(Char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Char))]
        public HutongGames.PlayMaker.FsmObject c2;

        [HutongGames.PlayMaker.ActionSection ("[arg3] char(Char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Char))]
        public HutongGames.PlayMaker.FsmObject c3;

        [HutongGames.PlayMaker.ActionSection ("[arg4] char(Char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Char))]
        public HutongGames.PlayMaker.FsmObject c4;

        [HutongGames.PlayMaker.ActionSection ("[return] int")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            c1 = null;
            c2 = null;
            c3 = null;
            c4 = null;
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

            if (!(c1.Value is OpenCVForUnityPlayMakerActions.Char))
            {
                LogError ("c1 is not initialized. Add Action \"newChar\".");
                return;
            }
            System.Char wrapped_c1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Char, System.Char> (c1);

            if (!(c2.Value is OpenCVForUnityPlayMakerActions.Char))
            {
                LogError ("c2 is not initialized. Add Action \"newChar\".");
                return;
            }
            System.Char wrapped_c2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Char, System.Char> (c2);

            if (!(c3.Value is OpenCVForUnityPlayMakerActions.Char))
            {
                LogError ("c3 is not initialized. Add Action \"newChar\".");
                return;
            }
            System.Char wrapped_c3 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Char, System.Char> (c3);

            if (!(c4.Value is OpenCVForUnityPlayMakerActions.Char))
            {
                LogError ("c4 is not initialized. Add Action \"newChar\".");
                return;
            }
            System.Char wrapped_c4 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Char, System.Char> (c4);

            storeResult.Value = OpenCVForUnity.VideoWriter.fourcc (wrapped_c1, wrapped_c2, wrapped_c3, wrapped_c4);


        }

    }

}
