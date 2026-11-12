using UnityEngine;

public class BoardTilt : MonoBehaviour
{
    [SerializeField] float maxTilt = 15f;
    [SerializeField] float tiltSpeed = 60f;
    Rigidbody rb;
    float targetX, targetZ;
    float currentX, currentZ;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        targetX = v*maxTilt;
        targetZ = -h *maxTilt;
    }
    void FixedUpdate(){
        currentX = Mathf.MoveTowards(currentX, targetX, tiltSpeed*Time.fixedDeltaTime);
        currentZ = Mathf.MoveTowards(currentZ, targetZ, tiltSpeed*Time.fixedDeltaTime);
        rb.MoveRotation(Quaternion.Euler(currentX, 0f, currentZ));
    }
    public void ResetTilt(){
        currentX =0;
        currentZ = 0;
        targetX = 0;
        targetZ = 0;
        rb.rotation = Quaternion.identity;
        transform.rotation = Quaternion.identity;
    }
}
