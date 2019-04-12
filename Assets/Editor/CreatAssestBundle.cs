using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class CreatAssestBundle
{
    [MenuItem("AssestBundle/Build AssestBundle")]
    static void BuildAssestBundle()
    {
        string path = Application.streamingAssetsPath;
        if(Directory.Exists(path))
        {
            Directory.Delete(path);
        }

        Directory.CreateDirectory(path);
        AssetDatabase.Refresh();

        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}
