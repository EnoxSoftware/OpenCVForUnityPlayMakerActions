using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.XimgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip("public static SelectiveSearchSegmentation createSelectiveSearchSegmentation()")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation), "storeResult")]
    public class Ximgproc_createSelectiveSearchSegmentation : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[return] SelectiveSearchSegmentation")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
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

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation)) storeResult.Value = new OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation();
            ((OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation)storeResult.Value).wrappedObject = OpenCVForUnity.XimgprocModule.Ximgproc.createSelectiveSearchSegmentation();


        }

    }

}
