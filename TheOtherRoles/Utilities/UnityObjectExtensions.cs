using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace TheOtherRoles.Utilities;

public static class UnityObjectExtensions
{
    public static T DontDestroy<T>(this T obj) where T : UnityObject
    {
        obj.hideFlags |= HideFlags.HideAndDontSave;

        return obj.DontDestroyOnLoad();
    }
    public static T DontUnload<T>(this T obj) where T : UnityObject
    {
        obj.hideFlags |= HideFlags.DontUnloadUnusedAsset;

        return obj;
    }

    public static T DontDestroyOnLoad<T>(this T obj) where T : UnityObject
    {
        UnityObject.DontDestroyOnLoad(obj);

        return obj;
    }

    public static void Destroy(this UnityObject obj)
    {
        UnityObject.Destroy(obj);
    }

    public static void DestroyImmediate(this UnityObject obj)
    {
        UnityObject.DestroyImmediate(obj);
    }
}
