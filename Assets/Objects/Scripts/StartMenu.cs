using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class StartMenu : MonoBehaviour
{    
    void Start()
    {
        //GameObject.FindWithTag("Background").GetComponent<PlayerMovement>().enabled = false;
        //var position = GameObject.FindWithTag("Background").GetComponent<Transform>().position;
        //position.y = 0f;
        if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting == false) GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().StopMusic();
        if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting == true) GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().PlayMusic();
        if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting == false) GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>().enabled = false;
        GameObject.FindGameObjectWithTag("MusicManager").GetComponent<AudioSource>().volume = 1f;
    }
    
    private class SettingsData
    {
        public bool musicSetting;
        public bool soundSetting;
    }
}
