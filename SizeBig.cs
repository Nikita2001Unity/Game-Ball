using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeBig : MonoBehaviour
{
    public GameObject player;
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            player.transform.localScale = -new Vector3(1f, 1f, 1f);
            Debug.Log("Size");
        }
    }
}
