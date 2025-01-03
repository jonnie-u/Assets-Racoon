using System;
using Unity.Android.Gradle;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        if (Application.isBatchMode)
        {
            return;
        }
        if (EditorApplication.isPlayingOrWillChangePlaymode)
        {
            return;
        }
        // FBXフォルダが存在していれば実行しない
        if (!AssetDatabase.IsValidFolder(Constants.FBXFolder))
        {
            EditorApplication.delayCall += SetupWizard.Open;
        }
    }
}
