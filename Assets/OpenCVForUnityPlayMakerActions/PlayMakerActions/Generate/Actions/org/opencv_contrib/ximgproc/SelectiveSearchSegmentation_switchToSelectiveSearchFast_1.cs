using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_ximgproc")]
    [HutongGames.PlayMaker.Tooltip ("public void switchToSelectiveSearchFast ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation), "owner")]
    public class SelectiveSearchSegmentation_switchToSelectiveSearchFast_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] SelectiveSearchSegmentation")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation))
            {
                LogError ("owner is not initialized. Add Action \"newSelectiveSearchSegmentation\".");
                return;
            }
            OpenCVForUnity.SelectiveSearchSegmentation wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SelectiveSearchSegmentation, OpenCVForUnity.SelectiveSearchSegmentation> (owner);

            wrapped_owner.switchToSelectiveSearchFast ();


        }

    }

}
