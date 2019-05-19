using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class OnToggleChanged : MonoBehaviour
{
    public Toggle music;
    public Toggle sound;

    private void Start()
    {
        //string json = File.ReadAllText(Application.dataPath + "/Config/config.json");
        //SettingsData settingsData = JsonUtility.FromJson<SettingsData>(json);
        
        if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting == true)
        {
            music.isOn = true;
        }
        else if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting == false)
        {
            music.isOn = false;
        }
        
        if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting == true)
        {
            sound.isOn = true;
        }
        else if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting == false)
        {
            sound.isOn = false;
        }
    }

    public void OnMusicChanged()
    {
//        if (GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().isMusicPlayed() == true)
//        {
//            GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().StopMusic();   
//        } 
//        else if (GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().isMusicPlayed() == false)
//        {
//            GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().PlayMusic();  
//        }
        string filePath = Path.Combine(Application.persistentDataPath, "config.json");
        //TextAsset file = Resources.Load("config") as TextAsset;
        //string json = file.ToString();
        string json = File.ReadAllText(filePath);
        SettingsData settingsData = JsonUtility.FromJson<SettingsData>(json);
        
        if (music.isOn == false)
        {
            GameObject.FindGameObjectWithTag("MusicManager").GetComponent<AudioSource>().enabled = false;
            settingsData.musicSetting = false;
            GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting = false;
        } 
        else if (music.isOn == true)
        {
            GameObject.FindGameObjectWithTag("MusicManager").GetComponent<AudioSource>().enabled = true;
            settingsData.musicSetting = true;
            GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting = true;
        }
        
        json = JsonUtility.ToJson(settingsData);
        File.WriteAllText(filePath, json);
    }
    
    
    public void OnSoundChanged()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "config.json");
        //TextAsset file = Resources.Load("config") as TextAsset;
        //string json = file.ToString();
        string json = File.ReadAllText(filePath);
        SettingsData settingsData = JsonUtility.FromJson<SettingsData>(json);
        
        if (sound.isOn == false)
        {
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>().enabled = false;
            settingsData.soundSetting = false;
            GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting = false;
        } 
        else if (sound.isOn == true)
        {
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>().enabled = true;
            settingsData.soundSetting = true;
            GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting = true;
        }

        json = JsonUtility.ToJson(settingsData);
        File.WriteAllText(filePath, json);
    }
    
    private class SettingsData
    {
        public bool musicSetting;
        public bool soundSetting;
    }
}
