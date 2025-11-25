using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] waypoints; 
    private int currentWaypointIndex = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (waypoints.Length > 0 && agent != null)
        {
            agent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        if (waypoints.Length == 0) return;

        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        agent.SetDestination(waypoints[currentWaypointIndex].position);
    }
}