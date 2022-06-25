using System.Collections;
using UnityEngine;
using HarmonyLib;
using Cinemachine;

namespace SmoothCamera.Patches
{
    [HarmonyPatch(typeof(GorillaLocomotion.Player))]
    [HarmonyPatch("Awake", MethodType.Normal)]
    class Patch
    {
        private static void Postfix(GorillaLocomotion.Player __instance)
        {
            __instance.StartCoroutine(Delay());
        }

        // https://github.com/Graicc/Utilla/blob/master/Utilla/HarmonyPatches/Patches/PostInitializedPatch.cs
        // I have no clue why this is needed though
        static IEnumerator Delay()
        {
            yield return 0;
            GameObject camera = GameObject.Find("Shoulder Camera");
            camera.GetComponent<CinemachineBrain>().enabled = false;
            camera.AddComponent<Behaviours.SmoothCamera>();
        }
    }
}
