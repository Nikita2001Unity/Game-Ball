using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject spheres;
    public string NameAnim;
   
    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            spheres.GetComponent<Animation>().Play(NameAnim);
        }
    }
}
