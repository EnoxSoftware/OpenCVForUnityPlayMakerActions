using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Xfeatures2dModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_xfeatures2d")]
    [HutongGames.PlayMaker.Tooltip ("public static void matchGMS (Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation, bool withScale, double thresholdFactor)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "size1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "size2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "keypoints1")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfKeyPoint), "keypoints2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch), "matches1to2")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch), "matchesGMS")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "withRotation")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "withScale")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "thresholdFactor")]
    public class Xfeatures2d_matchGMS_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject size1;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject size2;

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

        [HutongGames.PlayMaker.ActionSection ("[arg9] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat thresholdFactor;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            size1 = null;
            size2 = null;
            keypoints1 = null;
            keypoints2 = null;
            matches1to2 = null;
            matchesGMS = null;
            withRotation = false;
            withScale = false;
            thresholdFactor = 0.0f;
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

            if (!(size1.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("size1 is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped_size1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (size1);

            if (!(size2.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("size2 is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped_size2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (size2);

            if (!(keypoints1.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("keypoints1 is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfKeyPoint wrapped_keypoints1 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.CoreModule.MatOfKeyPoint> (keypoints1);

            if (!(keypoints2.Value is OpenCVForUnityPlayMakerActions.MatOfKeyPoint))
            {
                LogError ("keypoints2 is not initialized. Add Action \"newMatOfKeyPoint\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfKeyPoint wrapped_keypoints2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfKeyPoint, OpenCVForUnity.CoreModule.MatOfKeyPoint> (keypoints2);

            if (!(matches1to2.Value is OpenCVForUnityPlayMakerActions.MatOfDMatch))
            {
                LogError ("matches1to2 is not initialized. Add Action \"newMatOfDMatch\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfDMatch wrapped_matches1to2 = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDMatch, OpenCVForUnity.CoreModule.MatOfDMatch> (matches1to2);

            if (!(matchesGMS.Value is OpenCVForUnityPlayMakerActions.MatOfDMatch))
            {
                LogError ("matchesGMS is not initialized. Add Action \"newMatOfDMatch\".");
                return;
            }
            OpenCVForUnity.CoreModule.MatOfDMatch wrapped_matchesGMS = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfDMatch, OpenCVForUnity.CoreModule.MatOfDMatch> (matchesGMS);

            OpenCVForUnity.Xfeatures2dModule.Xfeatures2d.matchGMS (wrapped_size1, wrapped_size2, wrapped_keypoints1, wrapped_keypoints2, wrapped_matches1to2, wrapped_matchesGMS, withRotation.Value, withScale.Value, (float)thresholdFactor.Value);


        }

    }

}
