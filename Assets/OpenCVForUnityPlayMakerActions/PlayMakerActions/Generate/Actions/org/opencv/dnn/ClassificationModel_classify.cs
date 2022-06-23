#if !UNITY_WSA_10_0
using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.DnnModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_dnn")]
    [HutongGames.PlayMaker.Tooltip("public void classify(Mat frame, int[] classId, float[] conf)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.ClassificationModel), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Mat), "frame")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "classId")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "conf")]
    public class ClassificationModel_classify : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] ClassificationModel")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.ClassificationModel))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject frame;

        [HutongGames.PlayMaker.ActionSection("[arg2] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray classId;

        [HutongGames.PlayMaker.ActionSection("[arg3] float[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray conf;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            frame = null;
            classId = null;
            conf = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.ClassificationModel))
            {
                LogError("owner is not initialized. Add Action \"newClassificationModel\".");
                return;
            }
            OpenCVForUnity.DnnModule.ClassificationModel wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ClassificationModel, OpenCVForUnity.DnnModule.ClassificationModel>(owner);

            if (!(frame.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError("frame is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_frame = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat>(frame);

            int[] int_classId = classId.intValues;
            int[] casted_classId = new int[int_classId.Length];
            for (int i = 0; i < casted_classId.Length; i++)
            {
                casted_classId[i] = (int)int_classId[i];
            }

            float[] float_conf = conf.floatValues;
            float[] casted_conf = new float[float_conf.Length];
            for (int i = 0; i < casted_conf.Length; i++)
            {
                casted_conf[i] = (float)float_conf[i];
            }

            wrapped_owner.classify(wrapped_frame, casted_classId, casted_conf);

            for (int i = 0; i < casted_classId.Length; i++)
            {
                classId.Set(i, (int)casted_classId[i]);
            }
            classId.SaveChanges();

            for (int i = 0; i < casted_conf.Length; i++)
            {
                conf.Set(i, (float)casted_conf[i]);
            }
            conf.SaveChanges();


        }

    }

}
#endif
