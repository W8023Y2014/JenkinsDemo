﻿using System.Collections.Generic;
using UnityEditor;

namespace Tools
{
    public class APKBuild : Editor
    {
        [MenuItem("Tool/APKBuild")]
        public static void Build()
        {
            BuildTarget buildTarget = BuildTarget.Android;

            // 切换到 Android 平台
            EditorUserBuildSettings.SwitchActiveBuildTarget(buildTarget);

            //// keystore 路径, G:\keystore\one.keystore
            //PlayerSettings.Android.keystoreName = "G:\\keystore\\one.keystore";

            //// one.keystore 密码
            //PlayerSettings.Android.keystorePass = "123456";

            //// one.keystore 别名
            //PlayerSettings.Android.keyaliasName = "bieming1";

            //// 别名密码
            //PlayerSettings.Android.keyaliasPass = "123456";

            List<string> levels = new List<string>();
            foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
            {
                if (!scene.enabled)
                {
                    continue;
                }

                // 获取有效的 Scene
                levels.Add(scene.path);
            }

            // 打包出 APK 名
            string apkName = string.Format(@"C:\{0}.apk", "Test");

            // 执行打包
            string res = BuildPipeline.BuildPlayer(levels.ToArray(), apkName, buildTarget, BuildOptions.None);

            AssetDatabase.Refresh();
        }
    }
}