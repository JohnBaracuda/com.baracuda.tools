using UnityEngine;

namespace Baracuda.Tools.Editor
{
    public static class EditorMenuItemTools
    {
        [UnityEditor.MenuItem("Tools/HideFlags/Show Hidden GameObjects", priority = 2300)]
        private static void ShowAllHiddenObjects()
        {
            HideFlagsUtility.ShowAllHiddenObjects();
        }

        [UnityEditor.MenuItem("Tools/HideFlags/Show Hidden Inspector", priority = 2300)]
        private static void ShowAllHiddenInspector()
        {
            HideFlagsUtility.ShowAllHiddenInspector();
        }

        [UnityEditor.MenuItem("Tools/HideFlags/Validate Hide Flags", priority = 2300)]
        private static void ValidateAllObjectsHideFlags()
        {
            HideFlagsUtility.ValidateAllObjectsHideFlags();
        }

        [UnityEditor.MenuItem("Tools/EditorPrefs/Clear All EditorPrefs", priority = 280)]
        private static void ClearEditorPrefs()
        {
            UnityEditor.EditorPrefs.DeleteAll();
        }

        [UnityEditor.MenuItem("Tools/PlayerPrefs/Clear All EditorPrefs", priority = 280)]
        private static void ClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }

        [UnityEditor.MenuItem("Tools/Editor/Reload Domain", priority = 2400)]
        private static void ReloadDomain()
        {
            UnityEditor.Compilation.CompilationPipeline.RequestScriptCompilation();
        }
    }
}