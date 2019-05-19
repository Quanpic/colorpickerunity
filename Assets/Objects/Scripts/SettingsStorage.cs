using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SettingsStorage : MonoBehaviour
{
    private static SettingsStorage _settingsStorage;
    public bool musicSetting;
    public bool soundSetting;

    private void Awake()
    {
        if (_settingsStorage == null)
        {
            _settingsStorage = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        
        string filePath = Path.Combine(Application.persistentDataPath, "config.json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SettingsData settingsData = JsonUtility.FromJson<SettingsData>(json);

            musicSetting = settingsData.musicSetting;
            soundSetting = settingsData.soundSetting;
        } else
        {
            File.WriteAllText(filePath, "{\"musicSetting\":true,\"soundSetting\":true}");
            string json = File.ReadAllText(filePath);
            SettingsData settingsData = JsonUtility.FromJson<SettingsData>(json);

            musicSetting = settingsData.musicSetting;
            soundSetting = settingsData.soundSetting;
        }
        
        //TextAsset file = Resources.Load("config") as TextAsset;
        //string json = file.ToString();
        
    }
    
    private class SettingsData
    {
        public bool musicSetting;
        public bool soundSetting;
    }
}
