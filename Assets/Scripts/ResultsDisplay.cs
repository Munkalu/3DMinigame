using UnityEngine;
using TMPro;
public class ResultsDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text titleText;
    [SerializeField] TMP_Text statsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(GameManager.won){
            titleText.text = "Level Complete!";
        }
        else{
            titleText.text = "GAME OVER!";
        }
        statsText.text = "Score: " + GameManager.finalScore;
        
    }
}
