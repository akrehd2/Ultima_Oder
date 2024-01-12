// Copyright (C) 2018 Creative Spore - All Rights Reserved
using UnityEngine;
using System.IO;
using UnityEditor;

namespace CreativeSpore.RpgMapEditor
{
    [InitializeOnLoad]
    public class FixWrongAssetExtension : Editor
    {
        static FixWrongAssetExtension()
        {
            // Load all assets found in the project
            string[] guids = AssetDatabase.FindAssets("t:AutoTileMapData t:AutoTileSet");
            bool reloadAssets = false;
            foreach (var assetGuid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(assetGuid);
                if (Path.GetExtension(assetPath) == ".prefab")
                {
                    reloadAssets = true;
                    var newName = Path.GetFileNameWithoutExtension(assetPath) + ".asset";
                    Debug.Log("Fixed asset extension for " + assetPath + "\nRenamed to <color=purple>" + newName + "</color>");
                    var errorLog = RenameAssetNameAndExtension(assetPath, newName);
                    Debug.Assert(string.IsNullOrEmpty(errorLog), errorLog);
                }
            }
            if (reloadAssets)
                AssetDatabase.Refresh();
        }

        static string RenameAssetNameAndExtension(string assetPath, string newName)
        {
            string assetFullPath = Application.dataPath.Remove(Application.dataPath.Length - 6) + assetPath;
            string newAssetFullPath = Path.GetDirectoryName(assetFullPath) + "/" + newName;
            string metaFullPath = assetFullPath + ".meta";
            string newMetaFullPath = newAssetFullPath + ".meta";
            //Debug.Log(assetFullPath + "\n" + newAssetFullPath + "\n" + metaFullPath + "\n" + newMetaFullPath);
            try
            {
                File.Move(assetFullPath, newAssetFullPath);
                File.Move(metaFullPath, newMetaFullPath);
            }
            catch(System.Exception ex)
            {
                return ex.Message;
            }

            return "";
        }
    }
}
