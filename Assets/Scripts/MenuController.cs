using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void LoadScene(string sceneName){
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}