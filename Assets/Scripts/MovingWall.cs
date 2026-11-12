using UnityEngine;

public class MovingWall : MonoBehaviour
{
    [SerializeField] Vector3 moveAxis = Vector3.right;
    [SerializeField] float distance = 3f;
    [SerializeField] float speed = 1.5f;
    Rigidbody rb;
    Vector3 startLocal;
    Quaternion startLocalRot;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startLocal = transform.localPosition;
        startLocalRot = transform.localRotation;
    }
    void FixedUpdate()
    {
        float t = Mathf.PingPong(Time.time*speed, distance);
        Vector3 local = startLocal + moveAxis*t;
        rb.MovePosition(transform.parent.TransformPoint(local));
        rb.MoveRotation(transform.parent.rotation*startLocalRot);
    }
}
