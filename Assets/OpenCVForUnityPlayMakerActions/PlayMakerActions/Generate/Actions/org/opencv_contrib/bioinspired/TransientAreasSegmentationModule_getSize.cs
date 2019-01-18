using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.BioinspiredModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_bioinspired")]
    [HutongGames.PlayMaker.Tooltip ("public Size getSize ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "storeResult")]
    public class TransientAreasSegmentationModule_getSize : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] TransientAreasSegmentationModule")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[return] Size")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule))
            {
                LogError ("owner is not initialized. Add Action \"newTransientAreasSegmentationModule\".");
                return;
            }
            OpenCVForUnity.BioinspiredModule.TransientAreasSegmentationModule wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TransientAreasSegmentationModule, OpenCVForUnity.BioinspiredModule.TransientAreasSegmentationModule> (owner);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.Size)) storeResult.Value = new OpenCVForUnityPlayMakerActions.Size ();
            ((OpenCVForUnityPlayMakerActions.Size)storeResult.Value).wrappedObject = wrapped_owner.getSize ();


        }

    }

}
