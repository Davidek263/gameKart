using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform finish;
    public Transform player;

    void Start()
    {
        player = GameObject.Find("Kart").transform;
        finish = GameObject.Find("Finish").transform;
        agent.SetDestination(finish.position);
    }

    void Update() {
        Vector3 directionToPlayer = player.position - transform.position;
        directionToPlayer.y = 0;
        Vector3 playerForward = player.forward;
        float dotProduct = Vector3.Dot(playerForward, directionToPlayer.normalized);
        agent.speed = dotProduct < 0 ? 10f : 50f;
    }
}
