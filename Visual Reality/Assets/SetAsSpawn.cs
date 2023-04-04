using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAsSpawn : MonoBehaviour
{
    public GameObject currentObj;
    public SpawnerScript spawnScript;

    public void Set(){
        spawnScript.shapePrefab = currentObj;
    }
}
