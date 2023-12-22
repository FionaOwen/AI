using UnityEngine;
using Yarn.Unity;

public class YourCommandHandler : MonoBehaviour
{
    public void PerformAction(string command, string[] parameters, System.Action onComplete)
    {
        if (command == "spawnGameObject" && parameters.Length > 0)
        {
            string gameObjectName = parameters[0];
            // Use the gameObjectName to spawn the desired object in your scene
            GameObject yourGameObject = Resources.Load<GameObject>(gameObjectName);
            Instantiate(yourGameObject, Vector3.zero, Quaternion.identity);
        }

        onComplete();
    }
}