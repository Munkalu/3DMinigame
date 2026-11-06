using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
     public static int finalScore;
    public static bool won;
    bool gameOver;
    public int Lives {get; private set;}
    public int Score {get; private set;}
    public float TimeLeft {get; private set;}
    [SerializeField] int maxLives = 3;
    [SerializeField] float runLength = 120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
        Lives = maxLives;
        TimeLeft = runLength;
        Score = 0;
        won = false;
        finalScore = 0;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            return;
        }
        TimeLeft -= Time.deltaTime;
        if(TimeLeft<= 0){
            EndGame(true);
        }
        
    }
    public void LoseLife(){
        if(gameOver){
            return;
        }
        Lives--;
        if(Lives<=0){
            EndGame(false);
        }
    }
    void EndGame(bool didWin){
        
        gameOver = true;
        if(didWin){
            Score += 1000;
        }
        finalScore = Score;
        won = didWin;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Results");
    }
    public void LevelComplete(){
        if(gameOver){
            return;
        }
        else{
            EndGame(true);
        }
    }
}
