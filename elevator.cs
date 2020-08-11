using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public GameObject platform;
    public AudioClip clip;
    public AudioSource source;

    public string NameAnimat; // Its animation movement elevator


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            platform.GetComponent<Animation>().Play(NameAnimat);
            source.GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();
        }
    }
}
