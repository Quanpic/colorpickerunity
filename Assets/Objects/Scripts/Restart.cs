using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public void Replay()
    {   
        SceneManager.LoadScene("Game");
        GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>().Stop();
        if (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting == true) GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().PlayMusic();
    }
}
