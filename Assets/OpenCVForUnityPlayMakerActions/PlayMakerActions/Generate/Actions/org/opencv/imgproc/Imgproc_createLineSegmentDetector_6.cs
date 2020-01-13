using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public static LineSegmentDetector createLineSegmentDetector(int _refine, double _scale)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "_refine")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "_scale")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.LineSegmentDetector), "storeResult")]
    public class Imgproc_createLineSegmentDetector_6 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _refine;

        [HutongGames.PlayMaker.ActionSection("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject _scale;

        [HutongGames.PlayMaker.ActionSection("[return] LineSegmentDetector")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.LineSegmentDetector))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            _refine = 0;
            _scale = null;
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

            if (!(_scale.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("_scale is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped__scale = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(_scale);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.LineSegmentDetector)) storeResult.Value = new OpenCVForUnityPlayMakerActions.LineSegmentDetector();
            ((OpenCVForUnityPlayMakerActions.LineSegmentDetector)storeResult.Value).wrappedObject = OpenCVForUnity.ImgprocModule.Imgproc.createLineSegmentDetector(_refine.Value, wrapped__scale);


        }

    }

}
