using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public void getEdgeList(MatOfFloat4 edgeList)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Subdiv2D), "owner")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat4), "edgeList")]
    public class Subdiv2D_getEdgeList : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[class] Subdiv2D")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Subdiv2D))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection("[arg1] MatOfFloat4")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.MatOfFloat4))]
        public HutongGames.PlayMaker.FsmObject edgeList;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            owner = null;
            edgeList = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.Subdiv2D))
            {
                LogError("owner is not initialized. Add Action \"newSubdiv2D\".");
                return;
            }
            OpenCVForUnity.ImgprocModule.Subdiv2D wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Subdiv2D, OpenCVForUnity.ImgprocModule.Subdiv2D>(owner);

            if (!(edgeList.Value is OpenCVForUnityPlayMakerActions.MatOfFloat4))
            {
                LogError("edgeList is not initialized. Add Action \"newMatOfFloat4\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfFloat4 wrapped_edgeList = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfFloat4, OpenCVForUnity.CoreModule.MatOfFloat4>(edgeList);

            wrapped_owner.getEdgeList(wrapped_edgeList);


        }

    }

}
