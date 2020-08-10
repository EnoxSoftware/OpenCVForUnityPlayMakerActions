using UnityEngine;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public void Dispose ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DisposableOpenCVObject), "owner")]
    public class OpenCVForUnity_Dispose : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] DisposableOpenCVObject")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DisposableOpenCVObject))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

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
            if (!(owner.Value is OpenCVForUnityPlayMakerActions.DisposableOpenCVObject))
            {
                //                LogError ("owner is not initialized. Add Action \"newClassName\".");
                return;
            }
            OpenCVForUnityPlayMakerActions.DisposableOpenCVObject wrapper = owner.Value as OpenCVForUnityPlayMakerActions.DisposableOpenCVObject;
            OpenCVForUnity.DisposableOpenCVObject warapped = wrapper.wrappedObject as OpenCVForUnity.DisposableOpenCVObject;

            warapped.Dispose ();
            wrapper.wrappedObject = null;

            Object.Destroy (owner.Value);
            owner.Value = null;

        }

    }

}
