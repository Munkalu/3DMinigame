using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float bounceForce = 5f;
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Rigidbody rb = other.attachedRigidbody;
            Vector3 dir = other.transform.position - transform.position;
            dir.y = 0f;
            dir.Normalize();
            rb.linearVelocity = Vector3.zero;
            rb.AddForce(dir* bounceForce, ForceMode.Impulse);
        }
    }
}
