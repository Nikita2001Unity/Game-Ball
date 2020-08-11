
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerr gameManager;
    public AudioSource finish;
    public AudioClip finish1;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
        finish.GetComponent<AudioSource>();
        finish.clip = finish1;
        finish.Play();
    }
}
