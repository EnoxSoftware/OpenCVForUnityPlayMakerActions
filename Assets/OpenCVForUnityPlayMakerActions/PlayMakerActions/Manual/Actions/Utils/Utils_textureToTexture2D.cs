using UnityEngine;

using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static void textureToTexture2D (Texture texture, Texture2D texture2D)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (Texture), "texture")]
    [HutongGames.PlayMaker.ActionTarget (typeof (Texture2D), "texture2D")]
    public class Utils_textureToTexture2D : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Texture(texture)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (Texture))]
        public HutongGames.PlayMaker.FsmTexture
            texture;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Texture2D(texture)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (Texture2D))]
        public HutongGames.PlayMaker.FsmTexture
            texture2D;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            texture = null;
            texture2D = null;
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

            Utils.textureToTexture2D (texture.Value as Texture, texture2D.Value as Texture2D);

        }


    }

}
