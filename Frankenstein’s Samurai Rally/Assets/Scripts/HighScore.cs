using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    int[] hightScoreArray = new int[3];

    private void Start()
    {
        hightScoreArray = PlayerPrefsX.GetIntArray("HighScoreArray");
        if(hightScoreArray[0] == 0)
        {
            highScoreText.text = "NO RESULTS!";
        }
        else
        {
            highScoreText.text = "";
            for(int i = 0; hightScoreArray[i] != 0; i++)
            {
                highScoreText.text += (i + 1) + ".  " + hightScoreArray[i] + " Pkt" + System.Environment.NewLine;
                if(i == 2)
                {
                    break;
                }
            }
        }
    }
}
