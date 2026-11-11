using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ResultsDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text titleText;
    [SerializeField] TMP_Text statsText;
    [SerializeField] Image[] starImages;
    void Start()
    {
        for(int i =0; i<3; i++){
            if(i<GameManager.stars){
                starImages[i].color = new Color(1f,0.8f,.2f);
            }
            else{
                starImages[i].color = Color.gray;
            }
            
        }
        if(GameManager.won){
            titleText.text = "Level Complete!";
        }
        else{
            titleText.text = "GAME OVER!";
        }
        statsText.text = "Score: " + GameManager.finalScore +
         "\nSeeds: " + GameManager.seedsResult + "/" + GameManager.totalSeedsResult 
        + "\nTime Taken: " + Mathf.FloorToInt(GameManager.timeTaken/60) + ":" + Mathf.FloorToInt(GameManager.timeTaken%60).ToString("00");
        
    }
}
