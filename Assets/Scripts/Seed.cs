using UnityEngine;

public class Seed : MonoBehaviour
{
   void OnTriggerEnter(Collider other){
    if(other.CompareTag("Player")){
            GameManager.Instance.AddSeed();
            Destroy(gameObject);
        }
   }
}
