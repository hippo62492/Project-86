﻿using ScriptableObjects.GameParameters;
using UnityEngine;

[CreateAssetMenu(fileName = "DemoParameters", menuName = "Scriptable Objects/GameParameters/DemoParameters")]
public class DemoParameters : GameParameters
{
    [Range(1, 30)] public int spawnCount = 10;
    [Range(20, 1000)] public float spawnRadius = 100f;
    [Range(100, 1000)] public int ameiseHealth = 300;
    [Range(100, 1500)] public int loweHealth = 1000;
    [Range(0, 100)] public int ameiseLoweRatio = 66;
    public GameObject ameisePrefab;
    public GameObject lowePrefab;
    public override string GetParametersName => "Demo Settings";
}