using UnityEngine;
using Yarn.Unity;

public class KateInteraction : MonoBehaviour
{
    public GameObject marshmallowObject;

    [YarnCommand("takeMarshmellowsyouneed")]
    public void TakeMarshmellows()
    {

            Debug.Log("Player wants marshmallows! Implement your logic here.");

            // Activate the GameObject (marshmallowObject)
            if (marshmallowObject != null)
            {
                marshmallowObject.SetActive(true);
            }
        
    }

    [YarnCommand("donotwantmarshmellow")]
    public void WhatElse()
    {

            Debug.Log("Player doesn't want marshmallows! Implement your logic here.");

            // Deactivate the GameObject (marshmallowObject)
            if (marshmallowObject != null)
            {
                marshmallowObject.SetActive(false);
            }

    }
}
