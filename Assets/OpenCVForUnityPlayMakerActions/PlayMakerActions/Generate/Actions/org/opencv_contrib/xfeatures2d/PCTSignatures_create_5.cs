using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_xfeatures2d")]
    [HutongGames.PlayMaker.Tooltip ("public static PCTSignatures create (MatOfPoint2f initSamplingPoints, MatOfInt initClusterSeedIndexes)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f), "initSamplingPoints")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.MatOfInt), "initClusterSeedIndexes")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.PCTSignatures), "storeResult")]
    public class PCTSignatures_create_5 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] MatOfPoint2f")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfPoint2f))]
        public HutongGames.PlayMaker.FsmObject initSamplingPoints;

        [HutongGames.PlayMaker.ActionSection ("[arg2] MatOfInt")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.MatOfInt))]
        public HutongGames.PlayMaker.FsmObject initClusterSeedIndexes;

        [HutongGames.PlayMaker.ActionSection ("[return] PCTSignatures")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.PCTSignatures))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            initSamplingPoints = null;
            initClusterSeedIndexes = null;
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

            if (!(initSamplingPoints.Value is OpenCVForUnityPlayMakerActions.MatOfPoint2f))
            {
                LogError ("initSamplingPoints is not initialized. Add Action \"newMatOfPoint2f\".");
                return;
            }
            OpenCVForUnity.MatOfPoint2f wrapped_initSamplingPoints = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfPoint2f, OpenCVForUnity.MatOfPoint2f> (initSamplingPoints);

            if (!(initClusterSeedIndexes.Value is OpenCVForUnityPlayMakerActions.MatOfInt))
            {
                LogError ("initClusterSeedIndexes is not initialized. Add Action \"newMatOfInt\".");
                return;
            }
            OpenCVForUnity.MatOfInt wrapped_initClusterSeedIndexes = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.MatOfInt, OpenCVForUnity.MatOfInt> (initClusterSeedIndexes);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.PCTSignatures)) storeResult.Value = new OpenCVForUnityPlayMakerActions.PCTSignatures ();
            ((OpenCVForUnityPlayMakerActions.PCTSignatures)storeResult.Value).wrappedObject = OpenCVForUnity.PCTSignatures.create (wrapped_initSamplingPoints, wrapped_initClusterSeedIndexes);


        }

    }

}
