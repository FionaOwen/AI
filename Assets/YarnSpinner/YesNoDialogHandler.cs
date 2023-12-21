using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class YesNoDialogHandler : MonoBehaviour
{
    public GameObject objectToActivate;

    [YarnCommand("takeMarshmellows")]
    public void SetActiveYes()
    {
        Debug.Log("Take the marshmellow.");
        SetActive(true);
    }

    [YarnCommand("whatelse")]
    public void SetActiveNo()
    {
        Debug.Log("What else you need?");
        SetActive(false);
    }

    private void SetActive(bool isActive)
    {
       
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(isActive);
        }
    }
}
