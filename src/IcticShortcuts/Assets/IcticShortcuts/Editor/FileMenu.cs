using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace IcticShortcuts.Editor
{
    internal static class FileMenu
    {
        [MenuItem("File/Domain Reload %#&d")]
        public static void ReloadDomain()
        {
            AssetDatabase.SaveAssets();
            EditorUtility.RequestScriptReload();
            LogActionDone("Domain reloaded.");
        }

        [MenuItem("File/Regenerate Project Files %#&r")]
        public static void RegenerateProjectFiles()
        {
            Type syncVcType = Type.GetType("UnityEditor.SyncVS,UnityEditor");
            MethodInfo syncSolutionMethod = syncVcType!.GetMethod("SyncSolution", BindingFlags.Public | BindingFlags.Static);
            syncSolutionMethod!.Invoke(obj: null!, parameters: null!);
            LogActionDone("Project Files Regenerated.");
        }

        [MenuItem("File/Save Project and Scenes %#&s")]
        private static void SaveProjectAndScenes()
        {
            EditorApplication.ExecuteMenuItem("File/Save Project");
            EditorApplication.ExecuteMenuItem("File/Save");
            LogActionDone("Saved project and scenes");
        }

        private static void LogActionDone(string action) =>
            Debug.Log($"<color=#00ffff>{action}</color>");
    }
}