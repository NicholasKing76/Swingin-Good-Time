using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadTutorial()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadHowToPlay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("HowToPlay");
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    public void RetryLevel()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void level1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
    }
    public void LevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level Select");
    }
}
