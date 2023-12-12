using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider music;
    [SerializeField] private Slider notMusic;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume") && PlayerPrefs.HasKey("notMusicVolume"))
        {
            SaveVolume();
        }
        else
        {
            SetMusicVolume();
            setNotMusicVolume();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SaveVolume()
    {
        music.value = PlayerPrefs.GetFloat("musicVolume");
        notMusic.value = PlayerPrefs.GetFloat("notMusicVolume");

        setNotMusicVolume();
        SetMusicVolume();
    }

    public void setNotMusicVolume()
    {
        float nVolume = notMusic.value;
        PlayerPrefs.SetFloat("notMusicVolume", nVolume);
        mixer.SetFloat("notMusic", Mathf.Log10(nVolume) * 20);
    }

    public void SetMusicVolume()
    {
        float mVolume = music.value;
        PlayerPrefs.SetFloat("musicVolume", mVolume);
        mixer.SetFloat("Music", Mathf.Log10(mVolume)*20);
    }
}
