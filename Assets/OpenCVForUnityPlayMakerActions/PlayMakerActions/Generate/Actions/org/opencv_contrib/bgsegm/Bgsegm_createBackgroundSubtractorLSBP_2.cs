using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BgsegmModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_bgsegm")]
    [HutongGames.PlayMaker.Tooltip ("public static BackgroundSubtractorLSBP createBackgroundSubtractorLSBP (int mc, int nSamples, int LSBPRadius, float Tlower, float Tupper, float Tinc, float Tdec, float Rscale, float Rincdec, float noiseRemovalThresholdFacBG, float noiseRemovalThresholdFacFG)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "mc")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "nSamples")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "LSBPRadius")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "Tlower")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "Tupper")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "Tinc")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "Tdec")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "Rscale")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "Rincdec")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "noiseRemovalThresholdFacBG")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "noiseRemovalThresholdFacFG")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.BackgroundSubtractorLSBP), "storeResult")]
    public class Bgsegm_createBackgroundSubtractorLSBP_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt mc;

        [HutongGames.PlayMaker.ActionSection ("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt nSamples;

        [HutongGames.PlayMaker.ActionSection ("[arg3] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt LSBPRadius;

        [HutongGames.PlayMaker.ActionSection ("[arg4] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat Tlower;

        [HutongGames.PlayMaker.ActionSection ("[arg5] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat Tupper;

        [HutongGames.PlayMaker.ActionSection ("[arg6] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat Tinc;

        [HutongGames.PlayMaker.ActionSection ("[arg7] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat Tdec;

        [HutongGames.PlayMaker.ActionSection ("[arg8] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat Rscale;

        [HutongGames.PlayMaker.ActionSection ("[arg9] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat Rincdec;

        [HutongGames.PlayMaker.ActionSection ("[arg10] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat noiseRemovalThresholdFacBG;

        [HutongGames.PlayMaker.ActionSection ("[arg11] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat noiseRemovalThresholdFacFG;

        [HutongGames.PlayMaker.ActionSection ("[return] BackgroundSubtractorLSBP")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.BackgroundSubtractorLSBP))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            mc = 0;
            nSamples = 0;
            LSBPRadius = 0;
            Tlower = 0.0f;
            Tupper = 0.0f;
            Tinc = 0.0f;
            Tdec = 0.0f;
            Rscale = 0.0f;
            Rincdec = 0.0f;
            noiseRemovalThresholdFacBG = 0.0f;
            noiseRemovalThresholdFacFG = 0.0f;
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.BackgroundSubtractorLSBP)) storeResult.Value = new OpenCVForUnityPlayMakerActions.BackgroundSubtractorLSBP ();
            ((OpenCVForUnityPlayMakerActions.BackgroundSubtractorLSBP)storeResult.Value).wrappedObject = OpenCVForUnity.BgsegmModule.Bgsegm.createBackgroundSubtractorLSBP (mc.Value, nSamples.Value, LSBPRadius.Value, Tlower.Value, Tupper.Value, Tinc.Value, Tdec.Value, Rscale.Value, Rincdec.Value, noiseRemovalThresholdFacBG.Value, noiseRemovalThresholdFacFG.Value);


        }

    }

}
