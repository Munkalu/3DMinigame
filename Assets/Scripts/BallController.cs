using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 respawnPoint;
    void Start()
    {
        respawnPoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    public void SetCheckPoint(Vector3 point)
    {
        respawnPoint = point;
    }
    public void Respawn(){
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = respawnPoint;
    }
}
