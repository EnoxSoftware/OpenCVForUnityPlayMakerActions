using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static IEnumerator getFilePathAsync (string filepath, Action<string> completed, Action<string, float> progress = null, bool refresh = false)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "filepath")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEventTarget), "completedEventTarget")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "completedEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEventTarget), "progressEventTarget")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEvent), "progressEvent")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "refresh")]
    public class Utils_getFilePathAsync : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        public HutongGames.PlayMaker.FsmString
            filepath;

        [HutongGames.PlayMaker.ActionSection ("[arg2] FsmEventTarget")]
        public HutongGames.PlayMaker.FsmEventTarget
            completedEventTarget;

        [HutongGames.PlayMaker.ActionSection ("[arg3] FsmEvent EventData(string)")]
        [HutongGames.PlayMaker.Tooltip ("Event to send when completed.You can get the filePath(StringData) from the GetEventInfo action.")]
        public HutongGames.PlayMaker.FsmEvent
            completedEvent;

        [HutongGames.PlayMaker.ActionSection ("[arg4] FsmEventTarget")]
        public HutongGames.PlayMaker.FsmEventTarget
            progressEventTarget = new HutongGames.PlayMaker.FsmEventTarget ();

        [HutongGames.PlayMaker.ActionSection ("[arg5] FsmEvent EventData(string, float)")]
        [HutongGames.PlayMaker.Tooltip ("Event to send when progress.You can get the filePath(StringData) and progress(floatData) from the GetEventInfo action.")]
        public HutongGames.PlayMaker.FsmEvent
            progressEvent;

        [HutongGames.PlayMaker.ActionSection ("[arg6] bool")]
        public HutongGames.PlayMaker.FsmBool
            refresh;

        private Coroutine routine;

        public override void Reset ()
        {
            filepath = null;

            completedEventTarget = null;
            completedEvent = null;

            progressEventTarget.target = HutongGames.PlayMaker.FsmEventTarget.EventTarget.BroadcastAll;
            progressEvent = null;

            refresh = false;
        }

        public override void OnEnter ()
        {

            routine = StartCoroutine (Utils.getFilePathAsync (filepath.Value, (completedString) =>
            {

                HutongGames.PlayMaker.Fsm.EventData.StringData = completedString;
                Fsm.Event (completedEventTarget, completedEvent);

            }, (progressString, progressFloat) =>
            {

                HutongGames.PlayMaker.Fsm.EventData.StringData = progressString;
                HutongGames.PlayMaker.Fsm.EventData.FloatData = progressFloat;
                Fsm.Event (progressEventTarget, progressEvent);

            }, refresh.Value));
        }

        public override void OnExit ()
        {

            if (routine != null)
                StopCoroutine (routine);
        }
    }
}
