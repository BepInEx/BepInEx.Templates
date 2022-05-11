using BepInEx;
using BepInEx.NetLauncher;
using BepInEx.Logging;

namespace BepInEx6.PluginTemplate.NET
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static ManualLogSource Log;

        public override void Load()
        {
            // Plugin startup logic
            Log = Logger;
            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
