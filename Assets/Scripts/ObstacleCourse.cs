using UnityEngine;

public class ObstacleCourse : MonoBehaviour
{
    SetMudArea mudArea;
    [SerializeField] GameObject[] destinationPoints;  // 0 - 1st Point,  1 - 2nd Point

    private void Start()
    {
        mudArea = FindFirstObjectByType<SetMudArea>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player A"))
        {
            ToggleSideA();
        }
        else if (other.CompareTag("Player B"))
        {
            ToggleSideB();
        }
    }

    private void ToggleSideA()
    {
        destinationPoints[0].SetActive(false);
        destinationPoints[1].SetActive(true);
        mudArea.textTimer = 2.5f;
        mudArea.a++;
        mudArea.textMesh.text = $"Player A has reached checkpoint {mudArea.a} Times.";
    }

    private void ToggleSideB()
    {
        destinationPoints[0].SetActive(false);
        destinationPoints[1].SetActive(true);
        mudArea.textTimer = 2.5f;
        mudArea.b++;
        mudArea.textMesh.text = $"Player B has reached checkpoint {mudArea.b} Times.";
    }
}
