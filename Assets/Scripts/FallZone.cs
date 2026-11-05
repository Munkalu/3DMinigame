using UnityEngine;

public class FallZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other = "Player"){
            BallController = GetComponent<BallController>();
            BallController.Respawn();
        }
    }
}
