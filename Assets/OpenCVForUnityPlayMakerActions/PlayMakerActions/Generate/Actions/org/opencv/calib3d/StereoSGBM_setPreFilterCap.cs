using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Calib3dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_calib3d")]
    [HutongGames.PlayMaker.Tooltip("public void setPreFilterCap(int preFilterCap)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.StereoSGBM), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "preFilterCap")]
    public class StereoSGBM_setPreFilterCap : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] StereoSGBM")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.StereoSGBM))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt preFilterCap;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            preFilterCap = 0;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoProcess();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoProcess();
        }

        void DoProcess()
        {

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.StereoSGBM))
            {
                LogError("owner is not initialized. Add Action \"newStereoSGBM\".");
                return;
            }
            OpenCVForUnity.Calib3dModule.StereoSGBM wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.StereoSGBM, OpenCVForUnity.Calib3dModule.StereoSGBM>(owner);

            wrapped_owner.setPreFilterCap(preFilterCap.Value);


        }

    }

}
