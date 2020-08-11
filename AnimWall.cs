using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimWall : MonoBehaviour
{
    public string NameAnim;
    public GameObject player;
    public GameObject wall;

    public void OnTriggerEnter(Collider other)
    {
        if(player.transform == wall.transform)
        {
            player.GetComponent<Animation>().Play(NameAnim);
        }
    }
}
