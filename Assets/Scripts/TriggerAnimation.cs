using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator npcAnimator;
    public string[] animationName;
    public string[] otherCollidedObjectTag;
    private void Start()
    {
        npcAnimator = GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == otherCollidedObjectTag[0])
        {
            npcAnimator.Play(animationName[0]);
        }
        else if(other.tag == otherCollidedObjectTag[1])
        {
            npcAnimator.Play(animationName[1]);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            npcAnimator.Play(animationName[1]);
        }
    }
}
