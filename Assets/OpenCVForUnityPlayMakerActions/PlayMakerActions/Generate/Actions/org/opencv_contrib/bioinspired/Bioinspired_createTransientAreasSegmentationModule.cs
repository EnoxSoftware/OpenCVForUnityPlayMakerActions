using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static TransientAreasSegmentationModule createTransientAreasSegmentationModule (Size inputSize)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "inputSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule), "storeResult")]
    public class Bioinspired_createTransientAreasSegmentationModule : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject inputSize;

        [HutongGames.PlayMaker.ActionSection ("[return] TransientAreasSegmentationModule")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            inputSize = null;
            storeResult = null;
            everyFrame = false;
        }

        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame)
            {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {

            if (!(inputSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("inputSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.Size wrapped_inputSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.Size> (inputSize);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule)) storeResult.Value = new OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule ();
            ((OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule)storeResult.Value).wrappedObject = OpenCVForUnity.Bioinspired.createTransientAreasSegmentationModule (wrapped_inputSize);


        }

    }

}
