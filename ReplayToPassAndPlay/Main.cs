using BepInEx.Logging;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;

namespace ReplayToPassAndPlay;

public static class Main
{
    public static void Load(ManualLogSource logger)
    {
        ClassInjector.RegisterTypeInIl2Cpp<ReplayButton>();
        var go = new GameObject("ReplayToPassAndPlay");
        Object.DontDestroyOnLoad(go);
        go.hideFlags = HideFlags.HideAndDontSave;
        go.AddComponent<ReplayButton>();
    }
}
