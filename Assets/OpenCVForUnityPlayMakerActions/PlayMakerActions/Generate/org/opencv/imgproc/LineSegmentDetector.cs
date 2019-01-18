using UnityEngine;
using System.Collections;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;


namespace OpenCVForUnityPlayMakerActions
{
    public class LineSegmentDetector : OpenCVForUnityPlayMakerActions.Algorithm
    {

        public LineSegmentDetector ()
        {

        }

        public LineSegmentDetector (OpenCVForUnity.ImgprocModule.LineSegmentDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
