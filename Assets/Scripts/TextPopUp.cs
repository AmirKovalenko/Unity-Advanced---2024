using UnityEngine;

public class TextPopUp : MonoBehaviour
{
    SetMudArea mudArea;

    private void Start()
    {
        mudArea = FindFirstObjectByType<SetMudArea>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player A"))
        {
            TextForSideA();
        }
        else if (other.CompareTag("Player B"))
        {
            TextForSideB();
        }
    }

    private void TextForSideA()
    {
        mudArea.textTimer = 2.5f;
        mudArea.a++;
        mudArea.textMesh.text = $"Player A has reached end point {mudArea.a} times.";
    }

    private void TextForSideB()
    {
        mudArea.textTimer = 2.5f;
        mudArea.b++;
        mudArea.textMesh.text = $"Player B has reached end point {mudArea.b} times.";
    }

}
