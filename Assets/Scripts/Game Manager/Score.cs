using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float reset = 100f;
    public Text ScoreTutorial;
    public Text ScoreLevel2;
    public Text ScoreLevel3;
    // Start is called before the first frame update
    void Update()
    {
        ScoreTutorial.text =  "Time: " + PlayerPrefs.GetFloat("TutorialScore").ToString("F2") + " secs";
        ScoreLevel2.text = "Time: " + PlayerPrefs.GetFloat("Level2Score").ToString("F2") + " secs";
        ScoreLevel3.text = "Time: " + PlayerPrefs.GetFloat("Level3Score").ToString("F2") + " secs";
    }

    public void ResetScore()
    {
        PlayerPrefs.SetFloat("TutorialScore", reset);
        PlayerPrefs.SetFloat("Level2Score", reset);
        PlayerPrefs.SetFloat("Level3Score", reset);
    }
}
