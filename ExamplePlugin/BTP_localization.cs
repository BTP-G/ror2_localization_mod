using BepInEx;
using R2API;
using R2API.Utils;

namespace BTP_localization {
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [R2APISubmoduleDependency(nameof(LanguageAPI))]
    public class BTP_localization : BaseUnityPlugin {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "BTP";
        public const string PluginName = "BTP_localization";
        public const string PluginVersion = "1.0.0";
        public void Awake() {
            AddTokens();
        }
        private void AddTokens() {
            LanguageAPI.Add("ITEM_AbyssalMedkit_NAME", "阿比斯弹药包");
            LanguageAPI.Add("ITEM_AbyssalMedkit_LORE", "大脑。脊椎的一部分。几个器官。\n\n 用皮肉包裹起来。添加药物以消除疼痛。\n\n ... \n\n对不起，普鲁修卡，我真的很抱歉。\n\n<style=cEvent>我不会忘记你的，就像其他所有孩子一样</style>");
            LanguageAPI.Add("ITEM_AbyssalMedkit_PICKUP", "消耗品，可以替你抵挡10次debuffs，每一次抵挡都有概率给予你“祝福”");
            LanguageAPI.Add("ITEM_AbyssalMedkit_DESCRIPTION", "每一个可以替你<style=cIsUtility>抵挡10次</style>debuffs。每一次抵挡都有10%概率给予你<style=cIsHealing>“祝福”</style>。<style=cIsUtility>每个祝福可提升3%的所有属性</style> <style=cIsVoid>使所有医疗包无效化</style>.");
            LanguageAPI.Add("ITEM_BLESSING_NAME_NAME", "祝福");
            LanguageAPI.Add("ITEM_BLESSING_NAME_PICKUP", "凝视深渊过久，深渊将回以凝视！");
            LanguageAPI.Add("ITEM_BLESSING_NAME_DESCRIPTION", "凝视深渊过久，深渊将回以凝视！");
            LanguageAPI.Add("ITEM_CARTRIDGECONSUMED_NAME", "失效弹药包");
            LanguageAPI.Add("ITEM_CARTRIDGECONSUMED_PICKUP", "他过去想成为一名艺术家...");
            LanguageAPI.Add("ITEM_CARTRIDGECONSUMED_DESCRIPTION", "他过去想成为一名艺术家...");

        }
        private static void SetupConfig() {
            if (true) {
                targetLanguage = "default";
                RegisterFragment("OVERHEAL_BARRIER", "Excess healing generates <style=cIsHealing>barrier</style> for {0} of the amount you <style=cIsHealing>healed</style>.", "default");
                RegisterFragment("BARRIER_ARMOR", "\nIncreases <style=cIsHealing>armor</style> by {0} while <style=cIsHealing>barrier</style> is active.", "default");
                RegisterToken("ITEM_BARRIERONOVERHEAL_DESC", Aegis.DescriptionText(), "default");

            }
        }
    }
}
