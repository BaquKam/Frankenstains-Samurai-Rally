using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private GameObject GameManager;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MenuExitButton()
    {

    }
}
