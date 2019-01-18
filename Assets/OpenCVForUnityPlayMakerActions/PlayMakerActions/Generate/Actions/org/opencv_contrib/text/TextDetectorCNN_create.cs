#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TextModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip ("public static TextDetectorCNN create (string modelArchFilename, string modelWeightsFilename)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "modelArchFilename")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "modelWeightsFilename")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.TextDetectorCNN), "storeResult")]
    public class TextDetectorCNN_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString modelArchFilename;

        [HutongGames.PlayMaker.ActionSection ("[arg2] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString modelWeightsFilename;

        [HutongGames.PlayMaker.ActionSection ("[return] TextDetectorCNN")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.TextDetectorCNN))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            modelArchFilename = null;
            modelWeightsFilename = null;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TextDetectorCNN)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TextDetectorCNN ();
            ((OpenCVForUnityPlayMakerActions.TextDetectorCNN)storeResult.Value).wrappedObject = OpenCVForUnity.TextModule.TextDetectorCNN.create (modelArchFilename.Value, modelWeightsFilename.Value);


        }

    }

}
#endif
