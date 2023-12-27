using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.DrawMapInEditor();
            }
        }

        if (GUILayout.Button("Generate"))
        {
            mapGen.DrawMapInEditor();
        }

        if (GUILayout.Button("Reset"))
        {
            mapGen.noiseScale = 50;
            mapGen.octaves = 5;
            mapGen.persistance = 0.5f;
            mapGen.lacunarity = 2;
            mapGen.seed = 1;
            mapGen.offset.x = 0;
            mapGen.offset.y = 0;
            mapGen.meshHeightMultiplier = 31.1f;

            mapGen.DrawMapInEditor();
        }
    }
}