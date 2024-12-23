using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour
{
    CustomActions input;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] LayerMask clickableLayers;

    void Awake()
    {
        input = new CustomActions();
        AssignInput();
    }

    void AssignInput()
    {
        input.Main.Move.performed += ctx => MoveToDestination();
    }

    void MoveToDestination()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100, clickableLayers))
        {
            agent.destination = hit.point;
        }
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }


}
