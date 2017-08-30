using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static MapProjec toProjec (Map sourceMap)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Map), "sourceMap")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MapProjec), "storeResult")]
    public class MapTypeCaster_toProjec : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Map")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Map))]
        public HutongGames.PlayMaker.FsmObject sourceMap;

        [HutongGames.PlayMaker.ActionSection ("[return] MapProjec")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MapProjec))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            sourceMap = null;
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

            if (!(sourceMap.Value is OpenCVForUnityPlayMakerActions.Map))
            {
                LogError ("sourceMap is not initialized. Add Action \"newMap\".");
                return;
            }
            OpenCVForUnity.Map wrapped_sourceMap = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Map, OpenCVForUnity.Map> (sourceMap);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.MapProjec)) storeResult.Value = new OpenCVForUnityPlayMakerActions.MapProjec ();
            ((OpenCVForUnityPlayMakerActions.MapProjec)storeResult.Value).wrappedObject = OpenCVForUnity.MapTypeCaster.toProjec (wrapped_sourceMap);


        }

    }

}
