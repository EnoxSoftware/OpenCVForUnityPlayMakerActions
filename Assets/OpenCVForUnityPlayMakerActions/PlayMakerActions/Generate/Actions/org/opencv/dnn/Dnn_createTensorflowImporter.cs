#if !UNITY_WEBGL && !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip ("public static Importer createTensorflowImporter (string model)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "model")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Importer), "storeResult")]
    public class Dnn_createTensorflowImporter : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString model;

        [HutongGames.PlayMaker.ActionSection ("[return] Importer")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Importer))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            model = null;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Importer)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Importer ();
            ((OpenCVForUnityPlayMakerActions.Importer)storeResult.Value).wrappedObject = OpenCVForUnity.Dnn.createTensorflowImporter (model.Value);


        }

    }

}
#endif
