using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunkcionality : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefsX.GetIntArray("HighScoreArray", 0, 3)[0] == 0)
        {
            int[] highScoreInitializationArray = new int[3] { 0, 0, 0 };
            PlayerPrefsX.SetIntArray("HighScoreArray", highScoreInitializationArray);
        }
    }
    public void StartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
