using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartFall : MonoBehaviour
{
    public GameObject ResrtUI;
    public Rigidbody rb;
    void Start()
    {
        ResrtUI.SetActive(false);
    }

    public void Update()
    {
        if(rb.position.y < -5)
        {
            ResrtUI.SetActive(true);
            
            
        }
    }
   
}
