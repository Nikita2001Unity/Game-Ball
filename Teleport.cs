using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    
    public GameObject telep2;
    public GameObject player;
    public Vector3 teleport;
    public float speed = 1f;
    public AudioClip clip;
    public AudioSource source;

   

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.transform.position =  telep2.transform.position ;
            source.GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();
            

        }
    }
}
