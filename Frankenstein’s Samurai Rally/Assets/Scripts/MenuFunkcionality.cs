using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunkcionality : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefsX.GetIntArray("HighScoreArray", 0, 2)[0] == 0)
        {
            int[] highScoreInitializationArray = new int[2] { 0, 0 };
            PlayerPrefsX.SetIntArray("HighScoreArray", highScoreInitializationArray);
        }
    }
    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
