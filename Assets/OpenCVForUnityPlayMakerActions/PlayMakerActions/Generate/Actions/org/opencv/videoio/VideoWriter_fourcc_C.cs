using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_videoio")]
    [HutongGames.PlayMaker.Tooltip ("public static int fourcc (char c1, char c2, char c3, char c4)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "c1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "c2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "c3")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "c4")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "storeResult")]
    public class VideoWriter_fourcc_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] char(char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString c1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] char(char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString c2;

        [HutongGames.PlayMaker.ActionSection ("[arg3] char(char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString c3;

        [HutongGames.PlayMaker.ActionSection ("[arg4] char(char)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString c4;

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

            storeResult.Value = OpenCVForUnity.VideoWriter.fourcc ((char)c1.Value.ToCharArray ()[0], (char)c2.Value.ToCharArray ()[0], (char)c3.Value.ToCharArray ()[0], (char)c4.Value.ToCharArray ()[0]);


        }

    }

}
