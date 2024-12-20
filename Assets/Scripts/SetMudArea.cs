using UnityEngine;
using Unity.AI.Navigation;

public class SetMudArea : MonoBehaviour
{
    [SerializeField] GameObject trapVisual;
    [SerializeField] GameObject mudArea;
    [SerializeField] GameObject[] mudLocations;
    NavMeshSurface navMeshSurface;

    private void Start()
    {
        mudArea.SetActive(false);
        navMeshSurface = FindFirstObjectByType<NavMeshSurface>();
    }

    private void OnTriggerEnter(Collider other)
    {
        mudArea.SetActive(true);
        Debug.Log("activated mud zone");

        if (mudArea.transform.position != mudLocations[0].transform.position)  //set Mud on Point A location
        {
            mudArea.transform.position = mudLocations[0].transform.position;
            Debug.Log("Mud on Point A");
        }
        else if (mudArea.transform.position != mudLocations[1].transform.position)  //set mud on Point B location
        {
            mudArea.transform.position = mudLocations[1].transform.position;
            Debug.Log("Mud on Point B");
        }
        navMeshSurface.BuildNavMesh();

    }
}
