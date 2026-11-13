using UnityEngine;

public class Checkpoint : MonoBehaviour
{
   [SerializeField] Renderer flagRenderer;
   void OnTriggerEnter(Collider other){
    if(other.CompareTag("Player")){
            BallController ball = other.GetComponent<BallController>();
            ball.SetCheckPoint(transform);
            flagRenderer.material.color = Color.green;
        }
   }
}
