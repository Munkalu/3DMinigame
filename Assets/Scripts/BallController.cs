using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 startPoint;
    [SerializeField] BoardTilt board;
    Transform checkpoint;
    void Start()
    {
        startPoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    public void SetCheckPoint(Transform point)
    {
        checkpoint = point;
    }
    public void Respawn(){
        board.ResetTilt();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        if(checkpoint != null){
            transform.position = checkpoint.position + Vector3.up*0.5f;
        }
        else{
            transform.position = startPoint;
        }
        
    }
}
