using UnityEngine;
using Unity.AI.Navigation;
using TMPro;


public class SetMudArea : MonoBehaviour
{
    NavMeshSurface navMeshSurface;
    [SerializeField] GameObject[] mudLocations;
    [SerializeField] GameObject mudArea;
    [SerializeField] GameObject obstaclesA;
    [SerializeField] GameObject obstaclesB;

    public TextMeshProUGUI textMesh;
    [HideInInspector] public int a = 0;
    [HideInInspector] public int b = 0;
    [HideInInspector] public float textTimer = 0f;


    private void Start()
    {
        mudArea.SetActive(false);
        navMeshSurface = FindFirstObjectByType<NavMeshSurface>();
    }

    private void Update()
    {
        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
            if (textTimer < 0)
                TurnOffText();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        mudArea.SetActive(true);

        if (other.CompareTag("Player A"))
        {
            SetObstaclesOnSideA();
        }
        else if (other.CompareTag("Player B"))
        {
            SetObstaclesOnSideB();
        }
        navMeshSurface.BuildNavMesh();
    }
    private void SetObstaclesOnSideA() //set obstacles on Point A location
    {
        mudArea.transform.position = mudLocations[0].transform.position;
        obstaclesA.SetActive(true);
        obstaclesB.SetActive(false);
        Debug.Log("obstacles on Point A");
    }

    private void SetObstaclesOnSideB() //set obstacles on Point B location
    {
        mudArea.transform.position = mudLocations[1].transform.position;
        obstaclesA.SetActive(false);
        obstaclesB.SetActive(true);
        Debug.Log("obstacles on Point B");
    }

    private void TurnOffText()
    {
        textMesh.text = " ";
    }
}
