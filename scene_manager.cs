using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_manager : MonoBehaviour
{
    public void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadTitleScene()
    {

        SceneManager.LoadScene("title");

    }


    public void GameOverScene()
    {
        SceneManager.LoadScene("gameover");
    }

    public void QuitGame()                                        // loads quit
    {
        Application.Quit();
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("credits");



    }
    public void StartGame() 
    {
        SceneManager.LoadScene("gamescene1");
    
    }

}
