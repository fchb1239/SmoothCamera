using HarmonyLib;
using BepInEx;
using System.Reflection;
using System.ComponentModel;

namespace SmoothCamera
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [Description("HauntedModMenu")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            new Harmony(PluginInfo.GUID).PatchAll(Assembly.GetExecutingAssembly());
        }


        void OnEnable()
        {

        }

        void OnDisable()
        {

        }
    }
}
