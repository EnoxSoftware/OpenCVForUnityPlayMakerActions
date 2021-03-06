﻿using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_aruco")]
    [HutongGames.PlayMaker.Tooltip("public void draw(Size outSize, Mat img)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.CharucoBoard), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Size), "outSize")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "img")]
    public class CharucoBoard_draw_2 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] CharucoBoard")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.CharucoBoard))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject outSize;

        [HutongGames.PlayMaker.ActionSection("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject img;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            outSize = null;
            img = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.CharucoBoard))
            {
                LogError("owner is not initialized. Add Action \"newCharucoBoard\".");
                return;
            }
            OpenCVForUnity.ArucoModule.CharucoBoard wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.CharucoBoard, OpenCVForUnity.ArucoModule.CharucoBoard>(owner);

            if (!(outSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError("outSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped_outSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size>(outSize);

            if (!(img.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("img is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_img = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(img);

            wrapped_owner.draw(wrapped_outSize, wrapped_img);


        }

    }

}
