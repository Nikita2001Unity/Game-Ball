using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWall : MonoBehaviour
{

    public GameObject wall;

    public string NameAnim;


     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            wall.GetComponent<Animation>().Play(NameAnim);
        }
    }
}
