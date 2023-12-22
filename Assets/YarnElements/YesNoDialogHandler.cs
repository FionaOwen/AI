using UnityEngine;
using Yarn.Unity;
using Yarn;

public class YesNoDialogHandler : MonoBehaviour
{
    public GameObject marshmallowObject;
    public InMemoryVariableStorage yarnInMemoryStorage;



    [YarnCommand("take_marshmallowsyouneed")]
    public void TakeMarshmellowsyouneed()
    {
        bool readyToTake;
        yarnInMemoryStorage.TryGetValue("$wantmarshmellow", out readyToTake);
        Debug.Log("Player wants marshmallows! Implement your logic here." + readyToTake);
        if (readyToTake)
        {
            // Activate the GameObject (marshmallowObject)
            if (marshmallowObject != null)
            {
                marshmallowObject.SetActive(true);
            }
        }
    }

    [YarnCommand("donotwantmarshmellow")]
    public void Donotwantmarshmellow()
    {

            Debug.Log("Player doesn't want marshmallows! Implement your logic here.");

            // Deactivate the GameObject (marshmallowObject)
            if (marshmallowObject != null)
            {
                marshmallowObject.SetActive(false);
            }

    }
}
