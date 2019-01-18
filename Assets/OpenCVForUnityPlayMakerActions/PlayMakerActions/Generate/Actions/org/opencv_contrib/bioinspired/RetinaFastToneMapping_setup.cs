using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BioinspiredModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_bioinspired")]
    [HutongGames.PlayMaker.Tooltip ("public void setup (float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.RetinaFastToneMapping), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "photoreceptorsNeighborhoodRadius")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "ganglioncellsNeighborhoodRadius")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "meanLuminanceModulatorK")]
    public class RetinaFastToneMapping_setup : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] RetinaFastToneMapping")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.RetinaFastToneMapping))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat photoreceptorsNeighborhoodRadius;

        [HutongGames.PlayMaker.ActionSection ("[arg2] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat ganglioncellsNeighborhoodRadius;

        [HutongGames.PlayMaker.ActionSection ("[arg3] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat meanLuminanceModulatorK;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            photoreceptorsNeighborhoodRadius = 0.0f;
            ganglioncellsNeighborhoodRadius = 0.0f;
            meanLuminanceModulatorK = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.RetinaFastToneMapping))
            {
                LogError ("owner is not initialized. Add Action \"newRetinaFastToneMapping\".");
                return;
            }
            OpenCVForUnity.BioinspiredModule.RetinaFastToneMapping wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.RetinaFastToneMapping, OpenCVForUnity.BioinspiredModule.RetinaFastToneMapping> (owner);

            wrapped_owner.setup (photoreceptorsNeighborhoodRadius.Value, ganglioncellsNeighborhoodRadius.Value, meanLuminanceModulatorK.Value);


        }

    }

}
