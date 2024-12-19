using UnityEngine;

public class Gizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, radius: 0.3f);
    }
}
