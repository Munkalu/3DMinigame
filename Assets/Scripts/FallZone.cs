using UnityEngine;

public class FallZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            BallController ball = other.GetComponent<BallController>();
            ball.Respawn();
            GameManager.Instance.LoseLife();
        }
    }
}
