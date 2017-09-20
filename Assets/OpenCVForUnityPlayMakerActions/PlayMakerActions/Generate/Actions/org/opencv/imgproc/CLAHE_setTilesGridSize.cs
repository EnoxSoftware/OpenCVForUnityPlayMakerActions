using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_imgproc")]
    [HutongGames.PlayMaker.Tooltip ("public void setTilesGridSize (Size tileGridSize)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.CLAHE), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "tileGridSize")]
    public class CLAHE_setTilesGridSize : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] CLAHE")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.CLAHE))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject tileGridSize;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            tileGridSize = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.CLAHE))
            {
                LogError ("owner is not initialized. Add Action \"newCLAHE\".");
                return;
            }
            OpenCVForUnity.CLAHE wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.CLAHE, OpenCVForUnity.CLAHE> (owner);

            if (!(tileGridSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("tileGridSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.Size wrapped_tileGridSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.Size> (tileGridSize);

            wrapped_owner.setTilesGridSize (wrapped_tileGridSize);


        }

    }

}
