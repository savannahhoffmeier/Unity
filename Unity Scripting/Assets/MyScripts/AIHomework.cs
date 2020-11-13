using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIHomework : MonoBehaviour
{
    private NavMeshAgent Spy;
    public Transform Target;

    private void Start()
    {
        Spy = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Spy.destination = Target.position;
    }
}
