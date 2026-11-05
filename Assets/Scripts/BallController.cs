using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 respawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void SetCheckPoint(Vector3 point)
    {
        
    }
    public void Respawn(){
        rb.linearVelocity = 0;
        rb.angularVelocity = Vector3.zero;
        transform.position = respawnPoint;
    }
}
