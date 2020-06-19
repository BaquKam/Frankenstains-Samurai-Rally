using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider volume;

    private void Start()
    {
        volume.onValueChanged.AddListener(delegate { OnVolumeValueChanged(); });
    }
    public void OnVolumeValueChanged()
    {
        AudioListener.volume = volume.value;
    }
}
