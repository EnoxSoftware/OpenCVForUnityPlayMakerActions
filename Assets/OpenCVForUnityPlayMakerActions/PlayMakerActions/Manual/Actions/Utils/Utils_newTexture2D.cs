using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public Texture2D (int width, int height, TextureFormat format, bool mipmap, bool linear)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "width")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "height")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmEnum), "format")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "mipmap")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "linear")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmTexture), "storeResult")]
    public class Utils_newTexture2D : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt
            width;

        [HutongGames.PlayMaker.ActionSection ("[arg2] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt
            height;

        [HutongGames.PlayMaker.ActionSection ("[arg3] TextureFormat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (UnityEngine.TextureFormat))]
        public HutongGames.PlayMaker.FsmEnum
            format;

        [HutongGames.PlayMaker.ActionSection ("[arg4] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool
            mipmap;

        [HutongGames.PlayMaker.ActionSection ("[arg5] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool
            linear;

        [HutongGames.PlayMaker.ActionSection ("[return] Texture2D(texture)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmTexture))]
        public HutongGames.PlayMaker.FsmTexture
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            width = 0;
            height = 0;
            format = null;
            mipmap = false;
            linear = false;
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

            storeResult.Value = new Texture2D (width.Value, height.Value, (UnityEngine.TextureFormat)format.Value, mipmap.Value, linear.Value);

        }

    }

}
