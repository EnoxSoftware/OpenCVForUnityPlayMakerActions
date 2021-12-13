using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace OpenCVForUnityPlayMakerActions
{
    public class OpenCVForUnityPlayMakerActionsUtils
    {
        public static V GetWrappedObject<T, V>(HutongGames.PlayMaker.FsmObject fsmObject) where T : OpenCVForUnityPlayMakerActions.OpenCVObject
        {
            return (V)((T)fsmObject.Value).wrappedObject;
        }

        public static void ConvertFsmArrayToList<T, V>(HutongGames.PlayMaker.FsmArray fsmArray, List<V> list) where T : OpenCVForUnityPlayMakerActions.OpenCVObject
        {

            for (int i = 0; i < fsmArray.Length; i++)
            {
                if (fsmArray.Values[i] != null)
                {
                    list.Add((V)((T)fsmArray.Values[i]).wrappedObject);
                }
                else
                {

                }
            }

        }

        public static void ConvertListToFsmArray<V, T>(List<V> list, HutongGames.PlayMaker.FsmArray fsmArray) where T : OpenCVForUnityPlayMakerActions.OpenCVObject, new()
        {
            if (fsmArray.Length != list.Count)
            {
                fsmArray.Resize(list.Count);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (fsmArray.Values[i] != null)
                {
                    T tmp = (T)fsmArray.Values[i];
                    tmp.wrappedObject = list[i];
                }
                else
                {
                    T tmp = new T();
                    tmp.wrappedObject = list[i];
                    fsmArray.Set(i, tmp);
                }
            }
            fsmArray.SaveChanges();
        }

        public static void ConvertFsmArrayToArray<T, V>(HutongGames.PlayMaker.FsmArray fsmArray, V[] array) where T : OpenCVForUnityPlayMakerActions.OpenCVObject
        {

            for (int i = 0; i < fsmArray.Length; i++)
            {
                if (fsmArray.Values[i] != null)
                {
                    array[i] = (V)((T)fsmArray.Values[i]).wrappedObject;
                }
                else
                {

                }
            }

        }

        public static void ConvertArrayToFsmArray<V, T>(V[] array, HutongGames.PlayMaker.FsmArray fsmArray) where T : OpenCVForUnityPlayMakerActions.OpenCVObject, new()
        {
            if (fsmArray.Length != array.Length)
            {
                fsmArray.Resize(array.Length);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (fsmArray.Values[i] != null)
                {
                    T tmp = (T)fsmArray.Values[i];
                    tmp.wrappedObject = array[i];
                }
                else
                {
                    T tmp = new T();
                    tmp.wrappedObject = array[i];
                    fsmArray.Set(i, tmp);
                }
            }
            fsmArray.SaveChanges();
        }


    }
}
