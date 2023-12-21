using UnityEngine;
using UnityEngine.AI;

public class NPCFollowPlayer : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    private Animator animator;

    void Start()
    {
        // Assuming the NPC has a NavMeshAgent component
        navMeshAgent = GetComponent<NavMeshAgent>();

        // Assuming the NPC has an Animator component
        animator = GetComponent<Animator>();

        if (navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent component not found on NPC.");
        }

        if (animator == null)
        {
            Debug.LogError("Animator component not found on NPC.");
        }

        if (player == null)
        {
            Debug.LogError("Player reference not set on NPCFollowPlayer script.");
        }
    }

    void Update()
    {
        if (navMeshAgent != null && animator != null && player != null)
        {
            // Set the destination to the player's position
            navMeshAgent.SetDestination(player.position);

            // Check if the NPC is moving (use a small epsilon to account for floating point precision)
            bool isWalking = navMeshAgent.velocity.sqrMagnitude > 0.01f;

            // Update the Animator parameter for walking animation
            animator.SetBool("IsWalking", isWalking);
            animator.Play("Walking2");
        }
    }
}
