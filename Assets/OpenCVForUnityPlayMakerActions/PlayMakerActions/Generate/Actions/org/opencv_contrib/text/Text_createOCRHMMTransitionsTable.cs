using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_text")]
    [HutongGames.PlayMaker.Tooltip ("public static Mat createOCRHMMTransitionsTable (string vocabulary, List<string> lexicon)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "vocabulary")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "lexicon")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "storeResult")]
    public class Text_createOCRHMMTransitionsTable : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString vocabulary;

        [HutongGames.PlayMaker.ActionSection ("[arg2] List<string>(Array(string))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.String)]
        public HutongGames.PlayMaker.FsmArray lexicon;

        [HutongGames.PlayMaker.ActionSection ("[return] Mat")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            vocabulary = null;
            lexicon = null;
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

            string[] string_lexicon = lexicon.stringValues;
            List<string> wrapped_lexicon = new List<string> (string_lexicon);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Mat)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Mat ();
            ((OpenCVForUnityPlayMakerActions.Mat)storeResult.Value).wrappedObject = OpenCVForUnity.Text.createOCRHMMTransitionsTable (vocabulary.Value, wrapped_lexicon);

            wrapped_lexicon.CopyTo (string_lexicon);


        }

    }

}
