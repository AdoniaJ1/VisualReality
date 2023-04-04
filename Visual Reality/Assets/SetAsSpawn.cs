using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAsSpawn : MonoBehaviour
{
    public SpawnerScript spawner;
    void Start(){
        spawner = GetComponent<SpawnerScript>();
        Debug.Log("~~~SPAWNOBJECT~~~");
        Debug.Log(spawner.shapePrefab.name);
    }
}
