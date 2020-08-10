using UnityEngine;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public override int GetHashCode ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.OpenCVObject), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "storeResult")]
    public class OpenCVForUnity_GetHashCode : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] OpenCVObject")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.OpenCVObject))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("[return] int")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        public HutongGames.PlayMaker.FsmInt
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

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
            if (!(owner.Value is OpenCVForUnityPlayMakerActions.OpenCVObject))
            {
                LogError ("owner is not initialized. Add Action \"newClassName\".");
                return;
            }
            System.Object wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.OpenCVObject, System.Object> (owner);

            storeResult.Value = wrapped_owner.GetHashCode ();

        }


    }

}
