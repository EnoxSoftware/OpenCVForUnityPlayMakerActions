using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.FaceModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_face")]
    [HutongGames.PlayMaker.Tooltip("public static bool loadTrainingData(List<string> filename, List<MatOfPoint2f> trainlandmarks, List<string> trainimages)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "filename")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "trainlandmarks")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "trainimages")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmEvent), "trueEvent")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmEvent), "falseEvent")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmBool), "storeResult")]
    public class Face_loadTrainingData_5 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] List<string>(Array(string))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.String)]
        public HutongGames.PlayMaker.FsmArray filename;

        [HutongGames.PlayMaker.ActionSection("[arg2] List<MatOfPoint2f>(Array(MatOfPoint2f))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor(typeof(OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmArray trainlandmarks;

        [HutongGames.PlayMaker.ActionSection("[arg3] List<string>(Array(string))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.String)]
        public HutongGames.PlayMaker.FsmArray trainimages;

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
            filename = null;
            trainlandmarks = null;
            trainimages = null;
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

            string[] string_filename = filename.stringValues;
            List<string> wrapped_filename = new List<string>(string_filename);

            List<OpenCVForUnity.CoreModule.MatOfPoint2f> wrapped_trainlandmarks = new List<OpenCVForUnity.CoreModule.MatOfPoint2f>();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.CoreModule.MatOfPoint2f>(trainlandmarks, wrapped_trainlandmarks);

            string[] string_trainimages = trainimages.stringValues;
            List<string> wrapped_trainimages = new List<string>(string_trainimages);

            storeResult.Value = OpenCVForUnity.FaceModule.Face.loadTrainingData(wrapped_filename, wrapped_trainlandmarks, wrapped_trainimages);

            for (int i = 0; i < wrapped_filename.Count; i++)
            {
                filename.Set(i, (string)wrapped_filename[i]);
            }
            filename.SaveChanges();

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.CoreModule.MatOfPoint2f, OpenCVForUnityPlayMakerActions.MatOfPoint2f>(wrapped_trainlandmarks, trainlandmarks);

            for (int i = 0; i < wrapped_trainimages.Count; i++)
            {
                trainimages.Set(i, (string)wrapped_trainimages[i]);
            }
            trainimages.SaveChanges();

            Fsm.Event(storeResult.Value ? trueEvent : falseEvent);

        }

    }

}
