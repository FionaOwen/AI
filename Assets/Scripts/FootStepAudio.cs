using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FootstepAudio : MonoBehaviour
{
    public float movementThreshold = 0.1f;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        CheckingThePlayerMovement();
    }

    public void CheckingThePlayerMovement()
    {
        // Checking if the XR Rig is moving
        float movement = Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"));


        if (movement > movementThreshold && !audioSource.isPlaying)
        {
            audioSource.Play();
        }

        else if (movement < movementThreshold && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
