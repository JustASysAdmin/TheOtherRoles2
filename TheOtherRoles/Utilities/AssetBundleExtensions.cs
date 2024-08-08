using Il2CppInterop.Runtime;
using UnityEngine;

namespace TheOtherRoles.Utilities;

public static class AssetBundleExtensions
{
    public static T LoadAsset<T>(this AssetBundle bundle, string name) where T : Object
    {
        return bundle.LoadAsset(name, Il2CppType.Of<T>())?.Cast<T>();
    }
}
