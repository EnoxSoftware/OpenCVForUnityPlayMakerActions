using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_aruco")]
    [HutongGames.PlayMaker.Tooltip ("public static Dictionary custom_dictionary_from (int nMarkers, int markerSize, Dictionary baseDictionary)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "nMarkers")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "markerSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Dictionary), "baseDictionary")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Dictionary), "storeResult")]
    public class Aruco_custom_dictionary_from : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt nMarkers;

        [HutongGames.PlayMaker.ActionSection ("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt markerSize;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Dictionary")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Dictionary))]
        public HutongGames.PlayMaker.FsmObject baseDictionary;

        [HutongGames.PlayMaker.ActionSection ("[return] Dictionary")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Dictionary))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            nMarkers = 0;
            markerSize = 0;
            baseDictionary = null;
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

            if (!(baseDictionary.Value is OpenCVForUnityPlayMakerActions.Dictionary))
            {
                LogError ("baseDictionary is not initialized. Add Action \"newDictionary\".");
                return;
            }
            OpenCVForUnity.Dictionary wrapped_baseDictionary = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Dictionary, OpenCVForUnity.Dictionary> (baseDictionary);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Dictionary)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Dictionary ();
            ((OpenCVForUnityPlayMakerActions.Dictionary)storeResult.Value).wrappedObject = OpenCVForUnity.Aruco.custom_dictionary_from (nMarkers.Value, markerSize.Value, wrapped_baseDictionary);


        }

    }

}
