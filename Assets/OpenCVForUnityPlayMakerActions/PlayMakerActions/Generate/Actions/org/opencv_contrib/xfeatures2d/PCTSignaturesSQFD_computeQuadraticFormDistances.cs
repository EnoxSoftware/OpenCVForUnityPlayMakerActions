using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_xfeatures2d")]
    [HutongGames.PlayMaker.Tooltip ("public void computeQuadraticFormDistances (Mat sourceSignature, List<Mat> imageSignatures, MatOfFloat distances)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.PCTSignaturesSQFD), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "sourceSignature")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "imageSignatures")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfFloat), "distances")]
    public class PCTSignaturesSQFD_computeQuadraticFormDistances : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] PCTSignaturesSQFD")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.PCTSignaturesSQFD))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject sourceSignature;

        [HutongGames.PlayMaker.ActionSection ("[arg2] List<Mat>(Array(Mat))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmArray imageSignatures;

        [HutongGames.PlayMaker.ActionSection ("[arg3] MatOfFloat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfFloat))]
        public HutongGames.PlayMaker.FsmObject distances;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            sourceSignature = null;
            imageSignatures = null;
            distances = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.PCTSignaturesSQFD))
            {
                LogError ("owner is not initialized. Add Action \"newPCTSignaturesSQFD\".");
                return;
            }
            OpenCVForUnity.PCTSignaturesSQFD wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.PCTSignaturesSQFD, OpenCVForUnity.PCTSignaturesSQFD> (owner);

            if (!(sourceSignature.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("sourceSignature is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_sourceSignature = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (sourceSignature);

            List<OpenCVForUnity.Mat> wrapped_imageSignatures = new List<OpenCVForUnity.Mat> ();
            OpenCVForUnityPlayMakerActionsUtils.ConvertFsmArrayToList<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (imageSignatures, wrapped_imageSignatures);

            if (!(distances.Value is OpenCVForUnityPlayMakerActions.MatOfFloat))
            {
                LogError ("distances is not initialized. Add Action \"newMatOfFloat\".");
                return;
            }
            OpenCVForUnity.MatOfFloat wrapped_distances = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfFloat, OpenCVForUnity.MatOfFloat> (distances);

            wrapped_owner.computeQuadraticFormDistances (wrapped_sourceSignature, wrapped_imageSignatures, wrapped_distances);

            OpenCVForUnityPlayMakerActionsUtils.ConvertListToFsmArray<OpenCVForUnity.Mat, OpenCVForUnityPlayMakerActions.Mat> (wrapped_imageSignatures, imageSignatures);


        }

    }

}
