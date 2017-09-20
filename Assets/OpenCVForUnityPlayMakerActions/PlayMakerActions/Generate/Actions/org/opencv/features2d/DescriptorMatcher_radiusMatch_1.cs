using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_features2d")]
    [HutongGames.PlayMaker.Tooltip ("public void radiusMatch (Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.DescriptorMatcher), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "queryDescriptors")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "trainDescriptors")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "matches")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "maxDistance")]
    public class DescriptorMatcher_radiusMatch_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] DescriptorMatcher")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.DescriptorMatcher))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject queryDescriptors;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject trainDescriptors;

        [HutongGames.PlayMaker.ActionSection ("[arg3] List<MatOfDMatch>(Array(MatOfDMatch))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.MatOfDMatch))]
        public HutongGames.PlayMaker.FsmArray matches;

        [HutongGames.PlayMaker.ActionSection ("[arg4] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat maxDistance;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            queryDescriptors = null;
            trainDescriptors = null;
            matches = null;
            maxDistance = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.DescriptorMatcher))
            {
                LogError ("owner is not initialized. Add Action \"newDescriptorMatcher\".");
                return;
            }
            OpenCVForUnity.DescriptorMatcher wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.DescriptorMatcher, OpenCVForUnity.DescriptorMatcher> (owner);

            if (!(queryDescriptors.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("queryDescriptors is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_queryDescriptors = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (queryDescriptors);

            if (!(trainDescriptors.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("trainDescriptors is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_trainDescriptors = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (trainDescriptors);

            List<OpenCVForUnity.MatOfDMatch> wrapped_matches = new List<OpenCVForUnity.MatOfDMatch> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.MatOfDMatch, OpenCVForUnity.MatOfDMatch> (matches, wrapped_matches);

            wrapped_owner.radiusMatch (wrapped_queryDescriptors, wrapped_trainDescriptors, wrapped_matches, maxDistance.Value);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.MatOfDMatch, OpenCVForUnityPlayMakerActions.MatOfDMatch> (wrapped_matches, matches);


        }

    }

}
