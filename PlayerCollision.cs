
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject UIresrt;
    public PlayerMovement movement;
    public Text text;
    public AudioSource dead;
    public AudioClip dead1;
     void OnCollisionEnter(Collision collisionInfo)
     {
        if(collisionInfo.collider.tag == "Enemy")
        {
            movement.enabled = false;
            UIresrt.SetActive(true);
            //FindObjectOfType<GameManagerr>().EndGame();
            dead.GetComponent<AudioSource>();
            dead.clip = dead1;
            dead.Play();
            
        }
     }
}
