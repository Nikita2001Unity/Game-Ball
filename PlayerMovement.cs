using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public AudioClip clip;
    public AudioSource source;
    public float forwardForce = 2000f;
    public float SideWaysForce = 500f;


     void FixedUpdate()
     {
        rb.AddForce(0, -500f, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(SideWaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-SideWaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, SideWaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -SideWaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
      
     }
    public void Audio()
    {
        if (rb.position.y < -5f)
        {
            
            source.GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();
        }
    }

}
