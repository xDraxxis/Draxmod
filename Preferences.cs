using BoneLib.BoneMenu;
using MelonLoader;
using UnityEngine;

namespace bonelab_template // Must change this to the name of your mod or has a very High chance of causing issues!!!
{
    internal static class Preferences
    {
        private static MelonPreferences_Category MelonPrefCategory { get; set; }
        private static MelonPreferences_Entry<bool> MelonPrefEnabled { get; set; }
        private static bool IsEnabled { get; set; }
        
            internal static void MelonPreferencesCreator()
            {
                MelonPreferences.CreateCategory(Main.Name); // Create a new category in the MelonPreferences file
                MelonPreferences.CreateEntry(Main.Name, "Enabled", true, "Enable" + Main.Name); // Create a new entry in the MelonPreferences file
            }

        internal static void BoneMenuCreator()
        {
            var category = MenuManager.CreateCategory(Main.Name, Color.white); // Create a new category in the BoneMenu
            category.CreateBoolElement("Mod Toggle", "#FF5E00", IsEnabled, OnSetEnabled); // Create a mod toggle element in the BoneMenu
        }

        private static void OnSetEnabled(bool value) // This method is called when the mod toggle is changed
        {
            IsEnabled = value; // set the isEnabled value to the value of the mod toggle element
            MelonPrefEnabled.Value = value; // set the MelonPrefEnabled value to the value of the mod toggle element
            MelonPrefCategory.SaveToFile(false); // save the MelonPreferences file without logging
        }
    }
}