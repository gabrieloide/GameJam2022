using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    public Slider volume;
    public Slider music;
    public Slider vFx;
    public Toggle muteAll;
    public Toggle muteMusic;
    public Toggle muteVFx;
    public AudioMixer mixer;
    private float lastVolume1;
    private float lastVolume2;
    private float lastVolume3;
    private float volValue1;
    private float volValue2;
    private float volValue3;

    private void Start()
    {
        volume.value = PlayerPrefs.GetFloat("Volumen", 0f);
        music.value = PlayerPrefs.GetFloat("Musica", 0f);
        vFx.value = PlayerPrefs.GetFloat("Efx", 0f);
        
    }

    private void Awake()
    {
        volume.onValueChanged.AddListener(ChangeVolume);
        music.onValueChanged.AddListener(ChangeMusic);
        vFx.onValueChanged.AddListener(ChangeVFx);
    }
    
    //Mute Buttons
    public void setMuteVolume()
    {
        if (muteAll.isOn)
        {
            mixer.SetFloat("Master", lastVolume1);
            //volume.value = lastVolume;
        }
        else
        {
            mixer.GetFloat("Master", out lastVolume1);
            mixer.SetFloat("Master", -80);
            //volume.value = -80;
        }
    }
    
    public void setMuteMusic()
    {
        
        if(muteMusic.isOn)
        {
            mixer.SetFloat("Music", lastVolume2);
            //music.value = lastVolume;
        }
            
        else
        {
            mixer.GetFloat("Music", out lastVolume2);
            mixer.SetFloat("Music", -80);
            //music.value = -80;
        }
    }
    public void setMuteFx()
    {
        if (muteVFx.isOn)
        {
            mixer.SetFloat("VolFx", lastVolume3);
            //vFx.value = lastVolume;
        }
            
        else
        {
            mixer.GetFloat("VolFx", out lastVolume3);
            mixer.SetFloat("VolFx", -80);
            //vFx.value = -80;
        }
    }

    //Toggle disablers
    public void toggleChangedVol(bool newValue)
    {
        volume.interactable = newValue;
    }

    public void toggleChangedMus(bool newValue)
    {
        music.interactable = newValue;
    }
    public void toggleChangedFx(bool newValue)
    {
        vFx.interactable = newValue;
    }

    //Volume SliderChange
    public void ChangeVolume(float v)
    {
        mixer.SetFloat("Master", v);
        volume.value = v;
        volValue1 = v;
        PlayerPrefs.SetFloat("Volumen", volValue1);
    }
    public void ChangeMusic(float v)
    {
        mixer.SetFloat("Music", v);
        music.value = v;
        volValue2 = v;
        PlayerPrefs.SetFloat("Musica", volValue2);
    }
    public void ChangeVFx(float v)
    {
        mixer.SetFloat("VolFx", v);
        vFx.value = v;
        volValue3 = v;
        PlayerPrefs.SetFloat("Efx", volValue3);
    }


}
