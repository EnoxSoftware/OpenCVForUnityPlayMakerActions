using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnityPlayMakerActions
{

    public class OpenCVObject : UnityEngine.Object
    {

        public System.Object wrappedObject;

        public OpenCVObject()
        {

        }

        public OpenCVObject(System.Object wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }
    }
}