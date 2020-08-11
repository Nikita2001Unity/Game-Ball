using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMove : MonoBehaviour
{
    public GameObject button;
    public string NameAnim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            button.GetComponent<Animation>().Play(NameAnim);
        }
    }
}
