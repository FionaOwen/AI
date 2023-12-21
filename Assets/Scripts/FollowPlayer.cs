using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (target == null)
        {
            Debug.LogError("Target not assigned. Please assign a target in the inspector.");
        }
        else
        {
            SetDestination();
        }
    }

    void Update()
    {
        // Update the destination in case the target moves
        SetDestination();
    }

    void SetDestination()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
