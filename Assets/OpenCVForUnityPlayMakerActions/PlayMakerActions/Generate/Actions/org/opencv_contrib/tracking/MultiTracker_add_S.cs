﻿using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.TrackingModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_tracking")]
    [HutongGames.PlayMaker.Tooltip("public bool add(Tracker newTracker, Mat image, Rect2d boundingBox)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MultiTracker), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Tracker), "newTracker")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "image")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "boundingBox_x")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "boundingBox_y")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "boundingBox_width")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmFloat), "boundingBox_height")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmEvent), "trueEvent")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmEvent), "falseEvent")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "storeResult")]
    public class MultiTracker_add_S : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] MultiTracker")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MultiTracker))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] Tracker")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Tracker))]
        public HutongGames.PlayMaker.FsmObject newTracker;

        [HutongGames.PlayMaker.ActionSection("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject image;

        [HutongGames.PlayMaker.ActionSection("[arg3] Rect2d")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat boundingBox_x;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat boundingBox_y;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat boundingBox_width;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat boundingBox_height;

        [HutongGames.PlayMaker.ActionSection("[return] bool")]
        [HutongGames.PlayMaker.Tooltip("Event to send if result is true.")]
        public HutongGames.PlayMaker.FsmEvent trueEvent;

        [HutongGames.PlayMaker.Tooltip("Event to send if result is false.")]
        public HutongGames.PlayMaker.FsmEvent falseEvent;

        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            newTracker = null;
            image = null;
            boundingBox_x = 0.0f;
            boundingBox_y = 0.0f;
            boundingBox_width = 0.0f;
            boundingBox_height = 0.0f;
            trueEvent = null;
            falseEvent = null;
            storeResult = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.MultiTracker))
            {
                LogError("owner is not initialized. Add Action \"newMultiTracker\".");
                return;
            }
            OpenCVForUnity.TrackingModule.MultiTracker wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MultiTracker, OpenCVForUnity.TrackingModule.MultiTracker>(owner);

            if (!(newTracker.Value is OpenCVForUnityPlayMakerActions.Tracker))
            {
                LogError("newTracker is not initialized. Add Action \"newTracker\".");
                return;
            }
            OpenCVForUnity.TrackingModule.Tracker wrapped_newTracker = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Tracker, OpenCVForUnity.TrackingModule.Tracker>(newTracker);

            if (!(image.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("image is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_image = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(image);

            storeResult.Value = wrapped_owner.add(wrapped_newTracker, wrapped_image, new OpenCVForUnity.CoreModule.Rect2d((double)boundingBox_x.Value, (double)boundingBox_y.Value, (double)boundingBox_width.Value, (double)boundingBox_height.Value));

            Fsm.Event(storeResult.Value ? trueEvent : falseEvent);

        }

    }

}
