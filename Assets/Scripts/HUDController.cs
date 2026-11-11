using UnityEngine;
using TMPro;
public class HUDController : MonoBehaviour
{
    [SerializeField] TMP_Text hudText;
    [SerializeField] BallController player;
    void Update()
    {
        hudText.text = "Lives: " + GameManager.Instance.Lives+
        "\nScore: " + GameManager.Instance.Score + 
        "\nTime: " + Mathf.CeilToInt(GameManager.Instance.TimeLeft)
        +"\nSeeds Collected: " + GameManager.Instance.SeedsCollected + "/" + GameManager.Instance.TotalSeeds;  
    }
}