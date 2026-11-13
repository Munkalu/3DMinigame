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
    public int SeedsCollected => seedsCollected;
    public int TotalSeeds => totalSeeds;
    [SerializeField] int maxLives = 3;
    [SerializeField] float runLength = 120f;
    [SerializeField] float targetTime = 45f;
    [SerializeField] int pointsPerSeed = 100;
    int seedsCollected;
    int totalSeeds;
    public static  int stars;
    public static int seedsResult;
    public static int totalSeedsResult;
    public static float timeTaken;
    void Start()
    {
        Instance = this;
        Lives = maxLives;
        TimeLeft = runLength;
        Score = 0;
        won = false;
        finalScore = 0;
        Time.timeScale = 1f;
        seedsCollected = 0;
        stars = 0;
        seedsResult = 0;
        totalSeedsResult = 0;
        timeTaken = 0;
        totalSeeds = FindObjectsByType<Seed>(FindObjectsSortMode.None).Length;
    }
    void Update()
    {
        if(gameOver){
            return;
        }
        TimeLeft -= Time.deltaTime;
        if(TimeLeft<= 0){
            EndGame(false);
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
        timeTaken = runLength - TimeLeft;
        gameOver = true;
        if(didWin){
            Score += 1000;
            stars = 1;
            if(seedsCollected == totalSeeds){
            stars++;
        }
        if(timeTaken <= targetTime){
            stars++;
        }
        }
        finalScore = Score;
        won = didWin;
       
        seedsResult = seedsCollected;
        totalSeedsResult = totalSeeds;
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
    public void AddSeed(){
        seedsCollected++;
        Score += pointsPerSeed;
    }
}
