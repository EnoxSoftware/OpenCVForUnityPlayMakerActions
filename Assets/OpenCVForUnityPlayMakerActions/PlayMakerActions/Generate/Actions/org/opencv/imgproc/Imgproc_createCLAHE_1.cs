using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip("public static CLAHE createCLAHE(double clipLimit)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.Double), "clipLimit")]
    [HutongGames.PlayMaker.ActionTarget(typeof(OpenCVForUnityPlayMakerActions.CLAHE), "storeResult")]
    public class Imgproc_createCLAHE_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject clipLimit;

        [HutongGames.PlayMaker.ActionSection("[return] CLAHE")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(OpenCVForUnityPlayMakerActions.CLAHE))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            clipLimit = null;
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

            if (!(clipLimit.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError("clipLimit is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_clipLimit = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double>(clipLimit);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.CLAHE)) storeResult.Value = new OpenCVForUnityPlayMakerActions.CLAHE();
            ((OpenCVForUnityPlayMakerActions.CLAHE)storeResult.Value).wrappedObject = OpenCVForUnity.ImgprocModule.Imgproc.createCLAHE(wrapped_clipLimit);


        }

    }

}
