using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_saliency")]
    [HutongGames.PlayMaker.Tooltip ("public static MotionSaliencyBinWangApr2014 create ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014), "storeResult")]
    public class MotionSaliencyBinWangApr2014_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[return] MotionSaliencyBinWangApr2014")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014 ();
            ((OpenCVForUnityPlayMakerActions.MotionSaliencyBinWangApr2014)storeResult.Value).wrappedObject = OpenCVForUnity.MotionSaliencyBinWangApr2014.create ();


        }

    }

}
