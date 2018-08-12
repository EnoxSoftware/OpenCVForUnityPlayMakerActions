using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_xfeatures2d")]
    [HutongGames.PlayMaker.Tooltip ("public static void matchGMS (Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation, bool withScale)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "size1_width")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "size1_height")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "size2_width")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "size2_height")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "keypoints1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "keypoints2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch), "matches1to2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch), "matchesGMS")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "withRotation")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "withScale")]
    public class Xfeatures2d_matchGMS_1_S : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Size")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat size1_width;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat size1_height;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Size")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat size2_width;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat size2_height;

        [HutongGames.PlayMaker.ActionSection ("[arg3] MatOfKeyPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint))]
        public HutongGames.PlayMaker.FsmObject keypoints1;

        [HutongGames.PlayMaker.ActionSection ("[arg4] MatOfKeyPoint")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint))]
        public HutongGames.PlayMaker.FsmObject keypoints2;

        [HutongGames.PlayMaker.ActionSection ("[arg5] MatOfDMatch")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch))]
        public HutongGames.PlayMaker.FsmObject matches1to2;

        [HutongGames.PlayMaker.ActionSection ("[arg6] MatOfDMatch")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch))]
        public HutongGames.PlayMaker.FsmObject matchesGMS;

        [HutongGames.PlayMaker.ActionSection ("[arg7] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool withRotation;

        [HutongGames.PlayMaker.ActionSection ("[arg8] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool withScale;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            size1_width = 0.0f;
            size1_height = 0.0f;
            size2_width = 0.0f;
            size2_height = 0.0f;
            keypoints1 = null;
            keypoints2 = null;
            matches1to2 = null;
            matchesGMS = null;
            withRotation = false;
            withScale = false;
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

            if (!(keypoints1.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("keypoints1 is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.MatOfKeyPoint wrapped_keypoints1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.MatOfKeyPoint> (keypoints1);

            if (!(keypoints2.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("keypoints2 is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.MatOfKeyPoint wrapped_keypoints2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.MatOfKeyPoint> (keypoints2);

            if (!(matches1to2.Value is OpenCVForUnityPlayMakerActions.MatOfDMatch))
            {
                LogError ("matches1to2 is not initialized. Add Action \"newMatOfDMatch\".");
                return;
            }
            OpenCVForUnity.MatOfDMatch wrapped_matches1to2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDMatch, OpenCVForUnity.MatOfDMatch> (matches1to2);

            if (!(matchesGMS.Value is OpenCVForUnityPlayMakerActions.MatOfDMatch))
            {
                LogError ("matchesGMS is not initialized. Add Action \"newMatOfDMatch\".");
                return;
            }
            OpenCVForUnity.MatOfDMatch wrapped_matchesGMS = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDMatch, OpenCVForUnity.MatOfDMatch> (matchesGMS);

            OpenCVForUnity.Xfeatures2d.matchGMS (new OpenCVForUnity.Size ((double)size1_width.Value, (double)size1_height.Value), new OpenCVForUnity.Size ((double)size2_width.Value, (double)size2_height.Value), wrapped_keypoints1, wrapped_keypoints2, wrapped_matches1to2, wrapped_matchesGMS, withRotation.Value, withScale.Value);


        }

    }

}
