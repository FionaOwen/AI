using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetect : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            gameObject.SetActive(false);
            Debug.Log("Disable mashmellow");
        }
    }
}
