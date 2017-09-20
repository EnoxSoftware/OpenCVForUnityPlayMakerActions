using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_xfeatures2d")]
    [HutongGames.PlayMaker.Tooltip ("public static FREAK create (bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves, MatOfInt selectedPairs)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "orientationNormalized")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "scaleNormalized")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "patternScale")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "nOctaves")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "selectedPairs")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.FREAK), "storeResult")]
    public class FREAK_create : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool orientationNormalized;

        [HutongGames.PlayMaker.ActionSection ("[arg2] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool scaleNormalized;

        [HutongGames.PlayMaker.ActionSection ("[arg3] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat patternScale;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt nOctaves;

        [HutongGames.PlayMaker.ActionSection ("[arg5] MatOfInt")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmObject selectedPairs;

        [HutongGames.PlayMaker.ActionSection ("[return] FREAK")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.FREAK))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            orientationNormalized = false;
            scaleNormalized = false;
            patternScale = 0.0f;
            nOctaves = 0;
            selectedPairs = null;
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

            if (!(selectedPairs.Value is OpenCVForUnityPlayMakerActions.MatOfInt))
            {
                LogError ("selectedPairs is not initialized. Add Action \"newMatOfInt\".");
                return;
            }
            OpenCVForUnity.MatOfInt wrapped_selectedPairs = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (selectedPairs);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.FREAK)) storeResult.Value = new OpenCVForUnityPlayMakerActions.FREAK ();
            ((OpenCVForUnityPlayMakerActions.FREAK)storeResult.Value).wrappedObject = OpenCVForUnity.FREAK.create (orientationNormalized.Value, scaleNormalized.Value, patternScale.Value, nOctaves.Value, wrapped_selectedPairs);


        }

    }

}
