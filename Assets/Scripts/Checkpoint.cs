using UnityEngine;

public class Checkpoint : MonoBehaviour
{
   void OnTriggerEnter(Collider other){
    if(other.CompareTag("Player")){
            BallController ball = other.GetComponent<BallController>();
            ball.SetCheckPoint(transform);
            GetComponent<Renderer>().material.color = Color.green;
        }
   }
}
