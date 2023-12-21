using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource playerAudioSource;
    public int waitingTime;
    public int initialAudioWaitingTime;
    public string otherObjectTag;
    public bool stopAudioOnExit;
    public bool playAtStartAudio;


    private void Start()
    {
        StartCoroutine(PlayAudioAtStart());
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == otherObjectTag)
        {
            StartCoroutine(PlayAudios());
        }
    }
    //public void OnTriggerStay(Collider other)
    //{
    //    if (stopAudioOnExit)
    //    {
    //        if (other.tag == otherObjectTag)
    //        {
    //            StartCoroutine(StopAudioWithWaiting());
    //        }
    //    }
    //}
    IEnumerator PlayAudios()
    {
        //yield return new WaitForSeconds(initialAudioWaitingTime);

        playerAudioSource.PlayOneShot(audioClips[0]);

        yield return new WaitForSeconds(waitingTime);

        playerAudioSource.PlayOneShot(audioClips[1]);
    }
    
    IEnumerator StopAudioWithWaiting()
    {
        yield return new WaitForSeconds(waitingTime);
        playerAudioSource.Stop();   
    }

    IEnumerator PlayAudioAtStart()
    {
        if (playAtStartAudio)
        {

            yield return new WaitForSeconds(initialAudioWaitingTime);

            playerAudioSource.Play();
        }
    }
}
