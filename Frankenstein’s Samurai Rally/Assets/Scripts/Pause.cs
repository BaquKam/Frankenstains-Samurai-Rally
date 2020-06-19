using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseObj;
    private float tempTimeScale;

    public void PauseToggle()
    {
        if(Time.timeScale != 0)
        {
            tempTimeScale = Time.timeScale;
        }

        pauseObj.SetActive(!pauseObj.activeInHierarchy);

        if(Time.timeScale != 0f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = tempTimeScale;
        }
    }

    public void ResumeButton()
    {
        PauseToggle();
    }
    public void MenuExitButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
