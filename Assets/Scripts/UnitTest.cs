using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTest : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Other component " + other.gameObject.name.ToString());
    }
}
