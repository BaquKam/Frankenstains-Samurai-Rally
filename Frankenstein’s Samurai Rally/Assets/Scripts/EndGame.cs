using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    private GameObject GameManager;
    private GameObject Player;
    public Text gameScore;

    private int score;
    private int[] highScoresArray = new int[2];

    // Start is called before the first frame update
    void Start()
    {
        highScoresArray = PlayerPrefsX.GetIntArray("HighScoreArray");
        score = int.Parse(gameScore.text);
        if(score > highScoresArray[2])
        {
            for(int i = 0; i<2; i++)
            {
                if(score > highScoresArray[i])
                {
                    for(int j = 2; j>i; j--)
                    {
                        highScoresArray[j] = highScoresArray[j - 1];
                    }
                    highScoresArray[i] = score;
                    break;
                }
            }
        }
        PlayerPrefsX.SetIntArray("HighScoreArray", highScoresArray);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MenuExitButton()
    {
        SceneManager.LoadScene(1);
    }
}
