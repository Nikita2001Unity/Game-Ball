using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    [SerializeField]
    protected Joystick joystick;
    protected FixedJoyButton joyButton;
    public float speed = 20;
    public float SuperSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<FixedJoyButton>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = new Vector3( SuperSpeed, rigidbody.velocity.y, SuperSpeed);
        }
    }

}
