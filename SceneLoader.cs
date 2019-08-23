using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // cached component refrences
    GameStatus gamestatus;

    void Start()
    {
        gamestatus = FindObjectOfType<GameStatus>();
    }
    
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        //gamestatus.ResetGame();
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void LoadLevel6()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void LoadLevel7()
    {
        SceneManager.LoadScene("Level 7");
    }

    public void LoadLevel8()
    {
        SceneManager.LoadScene("Level 8");
    }

    public void LoadLevel9()
    {
        SceneManager.LoadScene("Level 9");
    }

    public void LoadLevel10()
    {
        SceneManager.LoadScene("Level 10");
    }

    public void LoadLevelMenu()
    {
        //gamestatus.ResetGame();
        SceneManager.LoadScene(1);
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadScene("Win Screen");
    }
}
