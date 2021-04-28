using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabStorage : MonoBehaviour
{
    public GameObject[] obstPrefabs;
    public GameObject[] carsPrefabs;


    public GameObject GetRandomPrefab()
    {
        var prefab = obstPrefabs[Random.Range(0, obstPrefabs.Length)];
        if (prefab.tag != "Car") return prefab;
        return carsPrefabs[Random.Range(0, carsPrefabs.Length)];
    }
}
