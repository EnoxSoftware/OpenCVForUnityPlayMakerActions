﻿using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip("public void set_MaxDistanceBetweenTwoLines(double MaxDistanceBetweenTwoLines)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.EdgeDrawing_Params), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "MaxDistanceBetweenTwoLines")]
    public class EdgeDrawing_Params_set_MaxDistanceBetweenTwoLines : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] EdgeDrawing_Params")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.EdgeDrawing_Params))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject MaxDistanceBetweenTwoLines;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            MaxDistanceBetweenTwoLines = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.EdgeDrawing_Params))
            {
                LogError("owner is not initialized. Add Action \"newEdgeDrawing_Params\".");
                return;
            }
            OpenCVForUnity.XimgprocModule.EdgeDrawing_Params wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.EdgeDrawing_Params, OpenCVForUnity.XimgprocModule.EdgeDrawing_Params>(owner);

            if (!(MaxDistanceBetweenTwoLines.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("MaxDistanceBetweenTwoLines is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_MaxDistanceBetweenTwoLines = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(MaxDistanceBetweenTwoLines);

            wrapped_owner.set_MaxDistanceBetweenTwoLines(wrapped_MaxDistanceBetweenTwoLines);


        }

    }

}
