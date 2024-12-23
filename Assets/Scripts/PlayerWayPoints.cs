using UnityEngine;
using UnityEngine.AI;

public class PlayerWayPoints : MonoBehaviour
{
    private const int mudAreaID = 3;
    private bool hasSpecialTevaNaot = true;

    [SerializeField] public NavMeshAgent navMeshAgent;
    [SerializeField] public Transform[] pathWaypoints;
    [SerializeField] static private Transform target = null;
    public int currentWaypointIndex;

    private void Start()
    {
        if (hasSpecialTevaNaot)
            navMeshAgent.SetAreaCost(areaIndex: mudAreaID, areaCost: 0.2f);
        navMeshAgent.SetDestination(pathWaypoints[0].position);
    }

    public static void SetTarget(Transform t)
    {
        target = t;
    }

    public void SetDestination()
    {
        navMeshAgent.SetDestination(pathWaypoints[currentWaypointIndex].position);
    }

    private void Update()
    {
        if (target)
        {
            navMeshAgent.SetDestination(target.position);
        }
        else if (!navMeshAgent.isStopped && navMeshAgent.remainingDistance <= 1.0f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= pathWaypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            navMeshAgent.SetDestination(pathWaypoints[currentWaypointIndex].position);
        }
    }

}
