using BoneLib;
using MelonLoader;

namespace bonelab_template // Must change this to the name of your mod or has a very High chance of causing issues!!!
{
    internal partial class Main
    {
        internal const string Name = "Mod Name"; // Name of the Mod.  (MUST BE SET)
        internal const string Description = null; // Description for the Mod.  (Set as null if none)
        internal const string Author = "Mod Author"; // Author of the Mod.  (MUST BE SET)
        internal const string Company = null; // Company that made the Mod.  (Set as null if none)
        internal const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        internal const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)

    }

    internal partial class Main : MelonMod
    {
        public override void OnEarlyInitializeMelon() // Runs before MelonLoader Initialization.
        {
            MelonLogger.Msg("OnApplicationEarlyStart");
        }
        public override void OnInitializeMelon() // Runs during MelonLoader Initialization.
        {
            MelonLogger.Msg("OnApplicationStart");
            
            Hooking.OnLevelInitialized += _ => { OnSceneAwake(); }; // This will call the OnSceneAwake() method in Main.cs when the level is initialized
            Preferences.MelonPreferencesCreator(); // This will call the MelonPreferencesCreator() method in Preferences.cs
            Preferences.BoneMenuCreator(); // This will call the BoneMenuCreator() method in Preferences.cs
        
        }

        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnApplicationLateStart");
        }
        
        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }
        
        public static void OnSceneAwake() //runs when the level is initialized
        {
            MelonLogger.Msg("OnSceneAwake");
        }
        
        public override void OnUpdate() // Runs once per frame.
        {
            MelonLogger.Msg("OnUpdate");
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            MelonLogger.Msg("OnFixedUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }
        
        
        
    }
}
