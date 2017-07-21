// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

using OpenCVForUnityExample;

namespace OpenCVForUnityPlayMakerActions
{
    // Base class for actions that access a Component on a GameObject.
    // Caches the component for performance
    public abstract class OptimizationWebCamTextureToHelperComponentAction<T> : HutongGames.PlayMaker.FsmStateAction where T : Component
    {
        private GameObject cachedGameObject;
        private T component;

        protected OptimizationWebCamTextureToMatHelper optimizationWebCamTextureToMatHelper
        {
            get { return component as OptimizationWebCamTextureToMatHelper; }
        }

        protected bool UpdateCache (GameObject go)
        {
            if (go == null)
            {
                return false;
            }

            if (component == null || cachedGameObject != go)
            {
                component = go.GetComponent<T> ();
                cachedGameObject = go;

                if (component == null)
                {
                    LogWarning ("Missing component: " + typeof (T).FullName + " on: " + go.name);
                }
            }

            return component != null;
        }
    }
}