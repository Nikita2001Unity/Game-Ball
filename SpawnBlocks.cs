using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject block;
    public  Vector3 spawnValues;
    private void Start()
    {
        SpawnBlock();
    }

    void SpawnBlock()
    {
        

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x , spawnValues.x), spawnValues.y , spawnValues.z);
        Quaternion spawnRotation =  Quaternion.identity;
        Instantiate(block, spawnPosition, spawnRotation);
    }
}
