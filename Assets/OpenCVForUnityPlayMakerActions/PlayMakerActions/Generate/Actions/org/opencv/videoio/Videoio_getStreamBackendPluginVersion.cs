using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.VideoioModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory("OpenCVForUnity_videoio")]
    [HutongGames.PlayMaker.Tooltip("public static string getStreamBackendPluginVersion(int api, int[] version_ABI, int[] version_API)")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmInt), "api")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "version_ABI")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmArray), "version_API")]
    [HutongGames.PlayMaker.ActionTarget(typeof(HutongGames.PlayMaker.FsmString), "storeResult")]
    public class Videoio_getStreamBackendPluginVersion : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt api;

        [HutongGames.PlayMaker.ActionSection("[arg2] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray version_ABI;

        [HutongGames.PlayMaker.ActionSection("[arg3] int[](Array(int))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ArrayEditor(HutongGames.PlayMaker.VariableType.Int)]
        public HutongGames.PlayMaker.FsmArray version_API;

        [HutongGames.PlayMaker.ActionSection("[return] string")]
        [HutongGames.PlayMaker.UIHint(HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType(typeof(HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString storeResult;

        [HutongGames.PlayMaker.ActionSection("")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            api = 0;
            version_ABI = null;
            version_API = null;
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

            int[] int_version_ABI = version_ABI.intValues;
            int[] casted_version_ABI = new int[int_version_ABI.Length];
            for (int i = 0; i < casted_version_ABI.Length; i++)
            {
                casted_version_ABI[i] = (int)int_version_ABI[i];
            }

            int[] int_version_API = version_API.intValues;
            int[] casted_version_API = new int[int_version_API.Length];
            for (int i = 0; i < casted_version_API.Length; i++)
            {
                casted_version_API[i] = (int)int_version_API[i];
            }

            storeResult.Value = OpenCVForUnity.VideoioModule.Videoio.getStreamBackendPluginVersion(api.Value, casted_version_ABI, casted_version_API);

            for (int i = 0; i < casted_version_ABI.Length; i++)
            {
                version_ABI.Set(i, (int)casted_version_ABI[i]);
            }
            version_ABI.SaveChanges();

            for (int i = 0; i < casted_version_API.Length; i++)
            {
                version_API.Set(i, (int)casted_version_API[i]);
            }
            version_API.SaveChanges();


        }

    }

}
