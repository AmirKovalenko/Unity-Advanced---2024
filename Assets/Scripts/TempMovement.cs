using UnityEngine;

public class TempMovement : MonoBehaviour
{
    public GameObject playerGO;

    void Update()
    {
        TemporaryMovement();
    }

    private void TemporaryMovement()  
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-5, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(5, 0, 0);
        }
    }

}
