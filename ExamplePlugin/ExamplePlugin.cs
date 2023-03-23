using BepInEx;
using R2API;
using R2API.Utils;

namespace ExamplePlugin {
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [R2APISubmoduleDependency(nameof(LanguageAPI))]
    public class ExamplePlugin : BaseUnityPlugin {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "BTP";
        public const string PluginName = "BTP_localization";
        public const string PluginVersion = "1.0.0";
        public void Awake() {
            AddTokens();
        }
        private void AddTokens() {
            //LanguageAPI.Add("AbyssalMedkit", "阿比斯弹夹");
        }
    }
}
