using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenSettings : MonoBehaviour
{

    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;

    public Toggle toggle;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.8f);

        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);

        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }


    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderValue);
    }

    public void ActiveFullScreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
