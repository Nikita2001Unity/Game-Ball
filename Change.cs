using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
   
    public GameObject player;
    public Material newMat;
    public AudioSource ch;
    public AudioClip au;
    




    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if(collisionInfo.collider.tag == "Player")
        {
          
           player.GetComponent<Renderer>().material = newMat;
            ch.GetComponent<AudioSource>();
            ch.clip = au;
            ch.Play();
            
            
        }
        Debug.Log(collisionInfo.collider.tag);
    }
}
