using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject menu;
    private bool isPaused;
    public GameObject endMenu;
    private bool isEnded;
    public Text timerScore;
    public Text endLevelTime;
    // Start is called before the first frame update
    void Start()
    {
     /*   Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("Player").GetComponent<MovementPlayer>().enabled = true;
        isPaused = false;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            if (Input.GetKeyDown("escape"))
            {
                PauseGame();
            }
        }
        else if (isPaused)
        {
            if (Input.GetKeyDown("escape"))
            {
                ResumeGame();
            }
        }

    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = !isPaused;
        menu.SetActive(isPaused);
        print("Game Paused");
        Cursor.lockState = CursorLockMode.Confined;
        GameObject.Find("Player").GetComponent<MovementPlayer>().enabled = false;
        Cursor.visible = true;
    }
    void ResumeGame()
    {
        Time.timeScale = 1f;
        menu.SetActive(!isPaused);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("Player").GetComponent<MovementPlayer>().enabled = true;
        isPaused = false;
    }

    public void LevelEnded()
    {
        Time.timeScale = 0f;
        //isEnded = !isEnded;
        print("Level Ended");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        GameObject.Find("Player").GetComponent<MovementPlayer>().enabled = false;
        endMenu.SetActive(true);
        endLevelTime.text = PlayerPrefs.GetString("TutorialTime");
    }
}
