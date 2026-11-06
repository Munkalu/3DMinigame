using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 respawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        respawnPoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
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
