using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_objdetect")]
    [HutongGames.PlayMaker.Tooltip ("public HOGDescriptor (Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels, bool _signedGradient)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "_winSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "_blockSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "_blockStride")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Size), "_cellSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "_nbins")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "_derivAperture")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "_winSigma")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "_histogramNormType")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "_L2HysThreshold")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "_gammaCorrection")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "_nlevels")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmBool), "_signedGradient")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.HOGDescriptor), "storeResult")]
    public class HOGDescriptor_newHOGDescriptor_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject _winSize;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject _blockSize;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject _blockStride;

        [HutongGames.PlayMaker.ActionSection ("[arg4] Size")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Size))]
        public HutongGames.PlayMaker.FsmObject _cellSize;

        [HutongGames.PlayMaker.ActionSection ("[arg5] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _nbins;

        [HutongGames.PlayMaker.ActionSection ("[arg6] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _derivAperture;

        [HutongGames.PlayMaker.ActionSection ("[arg7] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat _winSigma;

        [HutongGames.PlayMaker.ActionSection ("[arg8] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _histogramNormType;

        [HutongGames.PlayMaker.ActionSection ("[arg9] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat _L2HysThreshold;

        [HutongGames.PlayMaker.ActionSection ("[arg10] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool _gammaCorrection;

        [HutongGames.PlayMaker.ActionSection ("[arg11] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt _nlevels;

        [HutongGames.PlayMaker.ActionSection ("[arg12] bool")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmBool))]
        public HutongGames.PlayMaker.FsmBool _signedGradient;

        [HutongGames.PlayMaker.ActionSection ("[return] HOGDescriptor")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.HOGDescriptor))]
        public HutongGames.PlayMaker.FsmObject storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            _winSize = null;
            _blockSize = null;
            _blockStride = null;
            _cellSize = null;
            _nbins = 0;
            _derivAperture = 0;
            _winSigma = 0.0f;
            _histogramNormType = 0;
            _L2HysThreshold = 0.0f;
            _gammaCorrection = false;
            _nlevels = 0;
            _signedGradient = false;
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

            if (!(_winSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("_winSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped__winSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (_winSize);

            if (!(_blockSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("_blockSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped__blockSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (_blockSize);

            if (!(_blockStride.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("_blockStride is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped__blockStride = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (_blockStride);

            if (!(_cellSize.Value is OpenCVForUnityPlayMakerActions.Size))
            {
                LogError ("_cellSize is not initialized. Add Action \"newSize\".");
                return;
            }
            OpenCVForUnity.CoreModule.Size wrapped__cellSize = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Size, OpenCVForUnity.CoreModule.Size> (_cellSize);

            if (!(storeResult.Value is OpenCVForUnityPlayMakerActions.HOGDescriptor)) storeResult.Value = new OpenCVForUnityPlayMakerActions.HOGDescriptor ();
            ((OpenCVForUnityPlayMakerActions.HOGDescriptor)storeResult.Value).wrappedObject = new OpenCVForUnity.ObjdetectModule.HOGDescriptor (wrapped__winSize, wrapped__blockSize, wrapped__blockStride, wrapped__cellSize, _nbins.Value, _derivAperture.Value, (float)_winSigma.Value, _histogramNormType.Value, (float)_L2HysThreshold.Value, _gammaCorrection.Value, _nlevels.Value, _signedGradient.Value);


        }

    }

}
