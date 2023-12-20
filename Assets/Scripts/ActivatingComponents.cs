using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingComponents : MonoBehaviour
{
    public string otherGameObjectTag;
    public GameObject componentToActivate;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == otherGameObjectTag)
        {
            componentToActivate.SetActive(true);
        }
    }
}
