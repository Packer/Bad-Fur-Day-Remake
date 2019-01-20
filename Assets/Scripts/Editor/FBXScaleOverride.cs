using UnityEngine;
using UnityEditor;
using System;

public class MAXScaleOverride : AssetPostprocessor 
{
	void OnPreprocessModel() 
	{
		ModelImporter importer = assetImporter as ModelImporter;
		String name = importer.assetPath.ToLower();


		if (name.Substring(name.Length - 4, 4)==".max" && importer.globalScale == 1) 
		{
			importer.globalScale = 0.01F;
			importer.useFileScale = false;
			//importer.generateAnimations = ModelImporterGenerateAnimations.None;
		}
	}
}